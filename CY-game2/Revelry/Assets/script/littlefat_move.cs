using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class littlefat_move : MonoBehaviour
{
    public float speed = 1f;

    private int timer = 0;
    public int limit = 200;
    private float facing = 1f;

    //rigidbody and vector2
    public Rigidbody2D rigidbody;
    public Vector2 movement;

    //controller of player
    public Animator Animator;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (facing == 1f)
        {
            Animator.SetBool("goingdown", false);
        }
        else
        {
            Animator.SetBool("goingdown", true);
        }

        if (timer > limit)
        { 
            timer = 0;
            facing = facing * -1;
        }
        
         rigidbody.velocity = new Vector2(0f, facing);
        timer++;
        
    }
}
