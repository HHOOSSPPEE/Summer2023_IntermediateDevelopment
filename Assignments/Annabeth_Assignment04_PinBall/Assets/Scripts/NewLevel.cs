using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewLevel : MonoBehaviour
{
    //GameObject target;
    public bool activate;
    // Start is called before the first frame update
    void Start()
    {
        activate = false;
        //Vector3 p = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(transform.position.y);
        if (transform.position.y >= 0.48 && transform.position.y <= 0.5)
        {
            
            transform.position = new Vector3(0, 0.7f, 0);
            activate = true;
        }else if (transform.position.y >= 3.1 && transform.position.y <= 3.2)
        {
            transform.position = new Vector3(0, 3.4f, 0);
            activate = true;
        }

    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    transform.position = new Vector3(3.185f, 2.52f, 0);
    //}


}
