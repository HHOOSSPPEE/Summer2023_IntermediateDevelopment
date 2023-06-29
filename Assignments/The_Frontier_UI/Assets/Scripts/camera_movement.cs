using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_movement : MonoBehaviour
{
    public GameObject gameobject;
    public Transform target;
    public float smooth_speed = 0.125f;
    public Vector3 offest;

    private Vector3 _velocity = Vector3.zero;
    //public PlayerController player;

    public float limitLeft, limitRight, limitTop, limitBottom;


    // Start is called before the first frame update
    private void LateUpdate()
    {
        Transform currentTarget = target;

        Vector3 desiredPosition = currentTarget.position + offest;

        Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, desiredPosition, ref _velocity, smooth_speed);
        transform.position = smoothedPosition;


        transform.position = new Vector3(Mathf.Clamp(smoothedPosition.x, limitLeft, limitRight), Mathf.Clamp(smoothedPosition.y, limitBottom, limitTop), smoothedPosition.z);


        
        
    }
}
