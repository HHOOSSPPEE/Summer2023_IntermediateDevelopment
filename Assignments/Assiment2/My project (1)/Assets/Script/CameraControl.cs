using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    private Vector3 _velocity = Vector3.zero;

    public float limitLeft, limitRight, limitTop, limitBottom;
    //public PlayerControl player;
    // Start is called before the first frame update
    private void LateUpdate()
    {
        Transform currenTarget = target;

        Vector3 desiredPosition = currenTarget.position + offset;

        Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, desiredPosition, ref _velocity, smoothSpeed);

        //transform.position = smoothedPosition;

        transform.position = new Vector3(

            Mathf.Clamp(smoothedPosition.x, limitLeft, limitRight),
            Mathf.Clamp(smoothedPosition.y, limitBottom, limitTop),
            smoothedPosition.z);
    }
}
