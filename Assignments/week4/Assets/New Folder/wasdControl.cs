using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wasdControl : MonoBehaviour
{
    Rigidbody2D rb2D;
    public float speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody2D rb2D = GetComponent<Rigidbody2D>();
        if (Input.GetKey(KeyCode.A))
        {
            rb2D.AddForce(Vector2.left*speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb2D.AddForce(Vector2.right*speed);
        }
    }
}
