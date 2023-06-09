using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eevee_moving : MonoBehaviour
{
    //the speed of the player
    public float movespeed = 1f;

    //rigidbody and vector2
    public Rigidbody2D rigidbody;
    public Vector2 movement;

    //controller of player
    public Animator PlayerAnimator;

    //to store where player are in last frame
    public Vector2 Previouspostion;

    //do the player change the facing?
    private Boolean changeface;
    // Start is called before the first frame update
    void Start()
    {
        //to know where the player is in the 1st frame
        Previouspostion = rigidbody.position;
    }

    // Update is called once per frame
    void Update()
    {
        //know which buttom player press
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        //if player don't move set idle to true
        if (rigidbody.position == Previouspostion)
        {
            //idle
            PlayerAnimator.SetBool("idle", true);
            //reset facing
            changeface = false;
        }
        else
        {
            //when player move set idle to false
            PlayerAnimator.SetBool("idle", false);

            if (movement.y > 0 && changeface == false)
            {
                PlayerAnimator.SetInteger("facing", 1);//up
                //make player can't change facing
                changeface = true;
            }

            if (movement.x > 0 && changeface == false)
            {
                PlayerAnimator.SetInteger("facing", 2); //right
                //make player can't change facing
                changeface = true;
            }

            if (movement.x < 0 && changeface == false)
            {
                PlayerAnimator.SetInteger("facing", 3); //left
                //make player can't change facing
                changeface = true;
            }

            if (movement.y < 0 && changeface == false)
            {
                PlayerAnimator.SetInteger("facing", 4);//down
                //make player can't change facing
                changeface = true;
            }

        }
    }

    private void FixedUpdate()
    {
        //move the player
        rigidbody.MovePosition(rigidbody.position + movement * movespeed);
        //update the last postion
        Previouspostion = rigidbody.position;
    }
}
