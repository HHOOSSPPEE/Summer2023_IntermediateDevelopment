using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycaster : MonoBehaviour
{
    public Vector2 offset = new Vector2(0, 1);

    public LayerMask layerMask;

    // Update is called once per frame
    void FixedUpdate()
    {
        #region Raycast 2D
        /*// if you want to change the value of vector, you need to change the x and y individually.
        Vector2 origin = transform.position;
        origin.x = offset.x + transform.position.x;
        origin.y = offset.y + transform.position.y;

        //RaycastHit2D hit = Physics2D.Raycast(origin, Vector2.down); //build in direction
        //Debug.DrawRay(origin, -transform.up * hit.distance, Color.red);

        //Vector2 customV = new Vector2(2, 1);
        //RaycastHit2D hit = Physics2D.Raycast(origin, customV);//custom direction

        //RaycastHit2D hit = Physics2D.Raycast(transform.position, -transform.up);//rotate with character

        RaycastHit2D hit = Physics2D.Raycast(transform.position, -transform.up, Mathf.Infinity, layerMask);

        Debug.DrawRay(transform.position, -transform.up * hit.distance, Color.red);

        if(hit.collider != null)
        {
            Debug.Log("Hit");
        }*/
        #endregion

        #region Raycast (3D)
        /*RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.left), out hit, Mathf.Infinity, layerMask))
        {
            Debug.Log("3D Hit!");
        }*/
        #endregion

        #region CircleCast
        RaycastHit2D hit = Physics2D.CircleCast(transform.position, .5f, -transform.up);   
        if(hit.collider != null)
        {
            Debug.Log("Hit!");
        }
        #endregion
    }
}
