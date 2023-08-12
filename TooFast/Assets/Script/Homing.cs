using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Homing : MonoBehaviour
{
    private int lifetime = 400;
    public Transform target;
    public float speed = 30f;
    public float rotateSpeed = 200f;
    private Rigidbody2D rb;

    public GameObject explosionEffect;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Enemy").transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //life time
        lifetime --;

        // if there is no target just go up
        if (target == null)
        {
            rb.velocity = transform.up * speed;
        }

        //destory after lifetime hot 0
        if (lifetime < 0)
        {
            Destroy(gameObject);
        }

        //set the direction
        Vector2 direction = (Vector2)target.position - rb.position;

        direction.Normalize();


        float rotateAmount = Vector3.Cross(direction, transform.up).z;
        //set the rotation speed
        rb.angularVelocity = -rotateAmount * rotateSpeed;
        //move
        rb.velocity = transform.up * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //hit effect
        if (collision.gameObject.tag == "Enemy")
        {
            Instantiate(explosionEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
