using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_to_mouse : MonoBehaviour
{

    public float speed = 5f;
    private Vector3 target;

    // Start is called before the first frame update
    void Start()
    {
        target = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            target.z = transform.position.z;
            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        }
    }

       
}
