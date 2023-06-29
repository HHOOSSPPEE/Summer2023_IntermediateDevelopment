using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed = 1.5f;
    public int playerHealth = 100;
    public bool canTakeDamage = true;

    public Rigidbody2D _rigidbody;
    public Vector2 _movement;


    public Animator playerAnimator;
    public Vector2 _previousPosition;

    // Start is called before the first frame update
    void Start()
    {
        _previousPosition = _rigidbody.position; 
    }

    // Update is called once per frame
    void Update()
    {
        _movement.x = Input.GetAxisRaw("Horizontal");
        _movement.y = Input.GetAxisRaw("Vertical");

        //animation code
        if (_rigidbody.position == _previousPosition)
        {
            //idle
            playerAnimator.SetBool("moving", false);
        }
        else
        {
            playerAnimator.SetBool("moving", true);
            /*
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) //move up
            {
                Debug.Log("Up");
                playerAnimator.SetInteger("direction", 1); //1 = up
            }
            else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) //move left
            {
                Debug.Log("Left");
                playerAnimator.SetInteger("direction", 2); //2 = left
            }
            else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) //move down
            {
                Debug.Log("Down");
                playerAnimator.SetInteger("direction", 3); //3 = down
            }
            else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) //move right
            {
                Debug.Log("Right");
                playerAnimator.SetInteger("direction", 4); //4 = right
            }*/

            if(_movement.y > 0)
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
        



        //_previousPosition = _rigidbody.position;
    }

    private void FixedUpdate()
    {
        _rigidbody.MovePosition(_rigidbody.position + _movement * movementSpeed);

        _previousPosition = _rigidbody.position;
    }
}
