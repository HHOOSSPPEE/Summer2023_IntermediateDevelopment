using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.GraphicsBuffer;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed = 1.5f;
    
    public bool canTakeDamage = true;

    public GameObject AttackR;
    public GameObject monster;
    public GameObject MonsterI;
    private GameObject playerObj = null;
    //public Transform playerTransform;

    public Rigidbody2D _rigidbody;
    public HPManager HPManager;
    public Vector2 _movement;
    public int Corruption = 10;
    public float timeRemaining = 10;
    public float timeAttack = 1;
    public Animator playerAnimator;
    public Vector2 _previousPosition;
    public Transform playerTransform;

    // Start is called before the first frame update
    void Start()
    {
        _previousPosition = _rigidbody.position;
        gameObject.tag = "Player";
        Instantiate(HPManager);
        Instantiate(MonsterI);
    }

    // Update is called once per frame
    void Update()
    {
        //playerTransform = this.transform;
        _movement.x = Input.GetAxisRaw("Horizontal");
        _movement.y = Input.GetAxisRaw("Vertical");
        if (playerObj == null)
        {
            playerObj = GameObject.Find("Player_1");
        }

        //animation code
        if (_rigidbody.position == _previousPosition)
        {
            //idle
            playerAnimator.SetBool("moving", false);
        }
        else
        {
            playerAnimator.SetBool("moving", true);

            if (_movement.y > 0)
            {
                playerAnimator.SetInteger("direction", 1); //1 = up
            }
            if (_movement.x < 0)
            {
                playerAnimator.SetInteger("direction", 2); //2 = left
            }
            if (_movement.y < 0)
            {
                playerAnimator.SetInteger("direction", 3); //3 = down
            }
            if (_movement.x > 0)
            {
                playerAnimator.SetInteger("direction", 4); //4 = right
            }
        }
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        /* if (Input.GetKeyDown(KeyCode.Space))
         {
             Instantiate(plant, playerTransform.position, Quaternion.identity);
             Debug.Log("cool");
         }
        */

        //_previousPosition = _rigidbody.position;
        playerTransform = playerObj.GetComponent<Transform>();
        if (Input.GetKey(KeyCode.F) && timeAttack <= 0)
        {
            Instantiate(AttackR, _rigidbody.position, Quaternion.identity);
            timeAttack = 1;
        }
        if (timeAttack >= 0)
        {
            timeAttack -= Time.deltaTime;
        }
    }


 
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Monster")
        {
            HPManager.healthpoint += Corruption; 
        }
    }
    private void FixedUpdate()
    {
        _rigidbody.MovePosition(_rigidbody.position + _movement * movementSpeed);
       // _rigidbody.AddForce(_movement);
        _previousPosition = _rigidbody.position;
    }

    // private void moveCharacter()
    //{
    //  _rigidbody.AddForce(_movement);
    // }

 
}
