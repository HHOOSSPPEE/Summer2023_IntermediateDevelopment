using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class move : MonoBehaviour
{
    public float movespeed = 1.5f;
    public Rigidbody2D rigidbody;
    public Vector2 movement;

    public Animator PlayerAnimator;
    public Vector2 Previouspostion;
    // Start is called before the first frame update
    void Start()
    {
        Previouspostion = rigidbody.position;
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (rigidbody.position == Previouspostion)
        {
            //idle
            PlayerAnimator.SetBool("moving", false);
        }

        else
        {
            PlayerAnimator.SetBool("moving", true);

            if (movement.y > 0)
            {
                PlayerAnimator.SetInteger("direction", 1); 
            }

            if (movement.x > 0)
            {
                PlayerAnimator.SetInteger("direction", 2); //right
            }

            if (movement.x < 0)
            {
                PlayerAnimator.SetInteger("direction", 3); //left
            }

            if (movement.y < 0)
            {
                PlayerAnimator.SetInteger("direction", 4);
            }
        }


       

     
    }

    private void FixedUpdate()
    {
        rigidbody.MovePosition(rigidbody.position + movement * movespeed);
        Previouspostion = rigidbody.position;
    }
}
