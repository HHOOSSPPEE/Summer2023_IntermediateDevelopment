using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPowerUp : MonoBehaviour
{

    public GameObject explosionEffect;
    public AudioSource explosion;
    public Rigidbody2D rb;
    public float speed;
    public shake shakeffect;

    private void Awake()
    {
        explosion = GameObject.FindGameObjectWithTag("SoundS").GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
        shakeffect = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<shake>();
    }
    
    void Update()
    {
        //move power up
        rb.position = new Vector2(rb.position.x, rb.position.y + speed );
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.tag == "Player")
    //    {
    //        Debug.Log("!");
    //        Destroy(gameObject);
    //    }
    //}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //what happen after player catch powerup
        if (collision.gameObject.tag == "Player")
        {
            shakeffect.start = true;
            explosion.Play();
            Instantiate(explosionEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
