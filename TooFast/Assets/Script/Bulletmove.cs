using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Bulletmove : MonoBehaviour
{
    private int lifetime;
    public float ySpeed;
    public float xSpeed;
    private float mult = 1f;
    private Rigidbody2D rb;
    public GameObject explosionEffect;
    public SpeedManger SpeedManger;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        SpeedManger = GameObject.FindObjectOfType<SpeedManger>().GetComponent<SpeedManger>();
    }

   

    // Update is called once per frame
    void Update()
    {
        //speed up bullet trigger some problem so I give up
        //if (SpeedManger.Stage == 1)
        //{
        //    mult = 1;
        //}
        //else if (SpeedManger.Stage == 2)
        //{
        //    mult = 1.01f;
        //}else if (SpeedManger.Stage == 3) 
        //{
        //    mult = 1.02f; 
        //}
        rb.position = new Vector2((rb.position.x + xSpeed) * mult , (rb.position.y + ySpeed) * mult);
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.tag == "Enemy" && gameObject.tag == "Bullet")
    //    {
    //        Instantiate(explosionEffect, transform.position, transform.rotation);
    //        Destroy(gameObject);
    //    }
    //}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy" && gameObject.tag == "Bullet")
        {
            Instantiate(explosionEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
