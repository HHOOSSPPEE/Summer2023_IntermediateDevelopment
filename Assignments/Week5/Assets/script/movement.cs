using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody2D rb2D;
    public float speed = 1;
    public KeyCode Bumper = KeyCode.A;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody2D rb2D = GetComponent<Rigidbody2D>();
        if (Input.GetKey(Bumper))
        {
            rb2D.AddForce(Vector2.down * speed);
        }
    }
}
