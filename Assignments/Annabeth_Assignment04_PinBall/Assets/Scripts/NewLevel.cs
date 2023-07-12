using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewLevel : MonoBehaviour
{
    GameObject target;
    // Start is called before the first frame update
    void Start()


    {
        if(transform.position.y >= 2.35 && transform.position.y <= 2.45 && transform.position.x >= 2.7 && transform.position.x <= 3.6)
        {
            transform.position = new Vector3(transform.position.x, 2.52f, 0);
        }

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 p = transform.position;

    }
}
