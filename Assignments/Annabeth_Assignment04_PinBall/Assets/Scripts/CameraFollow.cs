using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    private Vector3 _pos;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, offset.z);
    }

    // Update is called once per frame
    void Update()
    {
        //if ((target.position.x + offset.x <= 1 && target.position.x + offset.x >= -1) && (target.position.y + offset.y <= 5.4 && target.position.y + offset.y >= 0))
        //{
        //    _pos = new Vector3(target.position.x + offset.x, target.position.y + offset.y, offset.z);

            //} else if (target.position.x + offset.x <= 1 && target.position.x + offset.x >= -1)
            //{
            //    _pos = new Vector3(target.position.x + offset.x, transform.position.y, offset.z);
            //}
            //else if (target.position.y + offset.y <= 5.4 && target.position.y + offset.y >= 0)
            //{
            //    //add y
            //    _pos = new Vector3(transform.position.x, target.position.y + offset.y, offset.z);

            //}

        if (target.position.y + offset.y <= 4.5 && target.position.y + offset.y >= 0)
        {
            //add y
            _pos = new Vector3(0, target.position.y + offset.y, offset.z);
            transform.position = _pos;

        }
        //transform.position = new Vector3(target.position.x + offset.x, target.position.y + offset.y, offset.z);
        


    } 
}
