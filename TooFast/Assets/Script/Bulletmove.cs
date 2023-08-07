using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Bulletmove : MonoBehaviour
{
    private int lifetime;
    public float ySpeed;
    public float xSpeed;
    public float mult;
    private Rigidbody2D rb;
    public GameObject explosionEffect;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

   

    // Update is called once per frame
    void Update()
    {
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
