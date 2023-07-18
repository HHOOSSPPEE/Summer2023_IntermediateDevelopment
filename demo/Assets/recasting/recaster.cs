using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recaster : MonoBehaviour
{
    public Vector2 offset = new Vector2 (0, 0);
    public LayerMask layermask;
  
    // Update is called once per frame
    void FixedUpdate()
    {
        #region Raycast 2d
        //Vector2 origin = transform.position;
        //origin.x = offset.x + transform.position.x;
        //origin.y = offset.y + transform.position.y;

        //Vector2 customV = new Vector2 (2,1);
        //RaycastHit2D hit = Physics2D.Raycast(transform.position, -transform.up,Mathf.Infinity,layermask);

        //Debug.DrawRay(transform.position, -transform.up * hit.distance,Color.red);

        //if (hit.collider != null)
        //{
        //    Debug.Log("Hit");
        //}
        #endregion

        //RaycastHit hit;

        //if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.left), Mathf.Infinity, layermask))
        //{ 
        //    Debug.Log("Hit")
        //}

        RaycastHit2D hit = Physics2D.CircleCast(transform.position, 5f, -transform.up);

        if (hit.collider != null)
        {
            Debug.Log("1");
        }
    }

}
