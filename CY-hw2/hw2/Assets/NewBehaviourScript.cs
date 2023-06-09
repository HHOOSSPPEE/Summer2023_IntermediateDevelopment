using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform target;
    public float smoothSpeed = 0.12f;
    public Vector3 offset;


    private Vector3 velocity = Vector3.zero;

    public float limitLeft, limitRight, limitTop, limitBottom;

    private void LateUpdate()
    {
        Transform currenTarget = target;

        Vector3 desirePostion = currenTarget.position + offset;

        Vector3 smoothPostion = Vector3.SmoothDamp(transform.position, desirePostion, ref velocity, smoothSpeed);
        transform.position = new Vector3(Mathf.Clamp(smoothPostion.x, limitLeft, limitRight), Mathf.Clamp(smoothPostion.y, limitBottom, limitTop), smoothPostion.x);
    }
}
