using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetBound : MonoBehaviour
{
    private float topBound = 20;
    private float lowerBound = -10;

    void Update()
    {
        if (transform.position.z > topBound)
        {
            //transform.position.z -= 5;
        }
        else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }
    }
}
