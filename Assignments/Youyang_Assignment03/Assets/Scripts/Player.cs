using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float movementSpeed = 1.5f;

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
        if (_rigidbody.position == _previousPosition)
        {
            playerAnimator.SetBool("moving", false); 

        }
        else
        {
            playerAnimator.SetBool("moving", true);

            //Animation code
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

            /*
            if (Input.GetKey(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) //move up //1
            {
                Debug.Log("Back");
                playerAnimator.SetInteger("direction", 1);
            }
            if (Input.GetKey(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) //move left //2
            {
                Debug.Log("Left");
                playerAnimator.SetInteger("direction", 2);
            }
            if (Input.GetKey(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)) //move down //3
            {
                Debug.Log("Front");
                playerAnimator.SetInteger("direction,", 3);
            }
            if (Input.GetKey(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) //move right //4
            {
                Debug.Log("Right");
                playerAnimator.SetInteger("direction", 4);
            }*/
        }

        _movement.x = Input.GetAxisRaw("Horizontal");
        _movement.y = Input.GetAxisRaw("Vertical");
        _previousPosition = _rigidbody.position;
    }

    private void FixedUpdate()
    {
        _rigidbody.MovePosition(_rigidbody.position + _movement * movementSpeed);
    }
}
