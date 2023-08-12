using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class Playermove : MonoBehaviour
{
    public float mult = 2;
    public Vector2 movement;
    private float x;
    private Rigidbody2D rb;
    public SpeedManger SpeedManger;
    public Animator animator;
    public SecondWind secondWind;

    public GameObject fire;
    public GameObject fire2;
  

    public scoresaver scoresaver;

    public int life = 15;

    public shake shakeffect;
    public GameObject explosionEffect;
    public AudioSource explosion;
    private void Awake()
    {
        shakeffect = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<shake>();
        explosion = gameObject.GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
        SpeedManger = GameObject.FindObjectOfType<SpeedManger>().GetComponent<SpeedManger>();
        animator = GetComponent<Animator>();
        scoresaver = GameObject.FindGameObjectWithTag("Score").GetComponent<scoresaver>();
        scoresaver.score = 0;
        secondWind = GameObject.FindGameObjectWithTag("SW").GetComponent<SecondWind>();
    }

    private void OnMovement(InputValue value)
    {
        //set the movement by input
        movement = value.Get<Vector2>();
        

    }

    private void FixedUpdate()
    {
        //move the player
        if (movement.x != 0 || movement.y != 0)
        {
           
            rb.velocity = movement * (mult + SpeedManger.Speedmult);
        }
    }

    private void Update()
    {
        //change the animation by input
        if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("Right", true);
            animator.SetBool("Left", false);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool("Right", false);
            animator.SetBool("Left", true);
        }
        else
        {
            animator.SetBool("Right", false);
            animator.SetBool("Left", false);
        }

        if (life <= 50)
        { 
            fire.SetActive(true);
        }

        if(life <=  15) 
        {
            fire2.SetActive(true);
        }
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //what happen after player hit Ebullet
        if (collision.gameObject.tag == "E-Bullet")
        {
            life--;
            Destroy(collision.gameObject);
            Instantiate(explosionEffect, transform.position, transform.rotation);
            explosion.Play();
            //when hp is lower than 0 trigger second wind
            if (life < 0) 
            {
                secondWind.BStill();
            }
            shakeffect.start = true;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //cost life when hit enemy
        if (collision.gameObject.tag == "Enemy")
        {
            life--;
            Destroy(collision.gameObject);
            Instantiate(explosionEffect, transform.position, transform.rotation);
            explosion.Play();
            shakeffect.start = true;
        }
    }
}
