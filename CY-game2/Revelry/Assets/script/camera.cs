using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    //set the target of the camera
    public Transform target;
    //the speed of the camera move
    public float smoothSpeed = 0.1f;
    //offset of the camera
    public Vector3 offset;
    //the speed pf the camera
    private Vector3 velocity = Vector3.zero;
    //limit camera
    public float limitLeft, limitRight, limitTop, limitBottom;

    // Start is called before the first frame update
    private void LateUpdate()
    {


        //read the camera to the target
        Transform currenTarget = target;

        //change the location of the camera
        Vector3 desirePostion = currenTarget.position + offset;

        //move the camera in a smoothway
        Vector3 smoothPostion = Vector3.SmoothDamp(transform.position, desirePostion, ref velocity, smoothSpeed);
        //limit the camera
        transform.position = new Vector3(Mathf.Clamp(smoothPostion.x, limitLeft, limitRight), Mathf.Clamp(smoothPostion.y, limitBottom, limitTop), smoothPostion.x);
    }
}
