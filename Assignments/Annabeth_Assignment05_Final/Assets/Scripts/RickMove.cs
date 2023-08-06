using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RickMove : MonoBehaviour
{
    public GameManager GM;

    private float speed = 5.0f;
    private float horizontalInput;
    private float verticalInput;
    public Rigidbody2D RB;
    Animator AM;

    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        AM = GetComponent<Animator>();
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        if (GM.characterChange == false)
        {
            RB.velocity = new Vector2(horizontalInput * speed, verticalInput * speed);
            AM.SetBool("walk_Rick", true);
        }
        if (horizontalInput == 0 && verticalInput == 0)
        {
            AM.SetBool("walk_Rick", false);
        }

        //transform.position = transform.position + new Vector3(horizontalInput * speed * Time.deltaTime, verticalInput * speed * Time.deltaTime, 0);
        //transform.Translate(Vector3.up * Time.deltaTime * speed * verticalInput);
        //transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);

    }

    //void OnTriggerEnter(Collider trig)
    //{
    //    Debug.Log("collide");
    //}
}
