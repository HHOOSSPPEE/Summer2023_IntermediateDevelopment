using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rigi : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector2.left * speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector2.right * speed);
        }
    }
}
