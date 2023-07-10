using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    private Vector3 _rotation = new Vector3(0, 0, 10);
    private float speed = 5;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(new Vector3(0, 0, 20) * Time.deltaTime);
        transform.Rotate(_rotation * speed * Time.deltaTime);
    }
}
