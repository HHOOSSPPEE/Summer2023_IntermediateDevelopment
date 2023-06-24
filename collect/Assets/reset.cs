using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class reset : MonoBehaviour
{

    public Rigidbody2D rigidbody;
    private float angle;
    private float speed;

    // Start is called before the first frame update
    void Start()
    {
         speed = Random.Range(1f, 2f);
    }

    // Update is called once per frame
    void Update()
    {   
        angle = Time.time * speed;
        transform.eulerAngles = Vector3.forward * angle * 15;
    }

    public void Reset()
    {
        rigidbody.position = new Vector2(Random.Range(25f, -25f), Random.Range(10f, 20f));
        rigidbody.velocity = new Vector2(0.1f, 1);
        
    }
}
