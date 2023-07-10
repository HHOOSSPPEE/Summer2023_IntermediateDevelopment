using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;

public class BallFly : MonoBehaviour
{
    private Rigidbody2D RB;
    public float speed;
    private bool act = false;

    void Start()
    {
        RB = GetComponent<Rigidbody2D>();

        // AddForce is a function of RigidBody2D

        //RB = GetComponent<Rigidbody>().AddForce(RO.transform.right * power, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouseDir = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        if (act == false && Input.GetMouseButtonDown(0))
        {
            RB.velocity = (mouseDir * speed);

            //RB.AddForce(Vector3(mouseDir, 0), ForceMode2D.Impulse);
            RB.WakeUp();
            RB.gravityScale = 1;
            act = true;
        }
    }
}