using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;

public class RotateAround : MonoBehaviour
{
    public GameObject target;
    private BoxCollider2D BC;
    private bool toRotate;
    private bool RotateBack;
    private bool lockRotate;

    
    // Start is called before the first frame update
    void Start()
    {
        BC = GetComponent<BoxCollider2D>();
        toRotate = false;
        RotateBack = false;
        lockRotate = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow) && !lockRotate)
        {
            StartCoroutine(RotatePoint());
            toRotate = true;
            lockRotate = true;
        }
        if (toRotate)
        {
            transform.RotateAround(target.transform.position, Vector3.back, 200 * Time.deltaTime);
        }
        if (RotateBack)
        {
            transform.RotateAround(target.transform.position, Vector3.forward, 200 * Time.deltaTime);
        }
            
    }
    //


    IEnumerator RotatePoint()
    {
        yield return new WaitForSeconds(0.15f);
        toRotate = false;
        BC.sharedMaterial.bounciness = 2;
        yield return new WaitForSeconds(1);
        RotateBack = true;
        BC.sharedMaterial.bounciness = 0.5f;

        yield return new WaitForSeconds(0.15f);
        RotateBack = false;
        lockRotate = false;
    }

}
