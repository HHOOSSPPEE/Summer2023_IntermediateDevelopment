using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(target.position.y + offset.y <= 5.4 && target.position.y + offset.y >= 0)
        {
            transform.position = new Vector3(0, target.position.y + offset.y, offset.z);
        }
            //transform.position = new Vector3(target.position.x + offset.x, target.position.y + offset.y, offset.z);
            
    }
}
