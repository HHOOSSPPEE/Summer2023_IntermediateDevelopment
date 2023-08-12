using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    private Vector3 _velocity = Vector3.zero;
    //public PlayerController player;

    public float limitLeft, limitRight, limitTop, limitBottom;

    private void LateUpdate()
    {
        Transform currentTarget = target;

        Vector3 desiredPosition = currentTarget.position + offset;

        Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, desiredPosition, ref _velocity, smoothSpeed);
        //transform.position = smoothedPosition;

        transform.position = new Vector3(
            Mathf.Clamp(smoothedPosition.x, limitLeft, limitRight),
            Mathf.Clamp(smoothedPosition.y, limitBottom, limitTop),
            smoothedPosition.z);
    }
}