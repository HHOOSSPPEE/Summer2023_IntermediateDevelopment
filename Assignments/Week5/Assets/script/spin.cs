using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class spin : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    public float angle;
    public float speed;
    public float mult = 1;
    // Start is called before the first frame update
    void Start()
    {
        speed = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        angle = Time.time * speed;
        transform.eulerAngles = Vector3.forward * angle * mult;
    }
}
