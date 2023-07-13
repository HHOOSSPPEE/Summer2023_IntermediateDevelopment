using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperControl : MonoBehaviour
{
    public bool Flipper;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if ((Flipper && Input.GetKey(KeyCode.RightControl))|| (!Flipper && Input.GetKey(KeyCode.LeftControl)))
            {
            GetComponent<HingeJoint2D>().useMotor = true; 
        }

        else
        {
            GetComponent<HingeJoint2D>().useMotor = false;
        }
        
    }
}
