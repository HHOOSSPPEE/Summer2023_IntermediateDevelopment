using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player_controller : MonoBehaviour
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

        _movement.x = Input.GetAxisRaw("Horizontal");
        _movement.y = Input.GetAxisRaw("Vertical");

        //animation code
        if (_rigidbody.position == _previousPosition)
        {
            //idle
            playerAnimator.SetBool("moving", false);
            playerAnimator.SetInteger("direction", 0);
        }
        else
        {
            playerAnimator.SetBool("moving", true);
            /*
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) //move up
            {
                playerAnimator.SetInteger("direction", 1); //1 = up

            }
            else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.RightArrow)) //move left
            {
                playerAnimator.SetInteger("direction", 2); //2 = left

            }
            else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) //move down
            {
                playerAnimator.SetInteger("direction", 3); //3 = down

            }
            else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.LeftArrow)) //move right
            {
                playerAnimator.SetInteger("direction", 4); //4 = right

            }
            */

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

        _previousPosition = _rigidbody.position;


    }

    private void FixedUpdate()
    {
        _rigidbody.MovePosition(_rigidbody.position + _movement * movementSpeed);
    }


}
