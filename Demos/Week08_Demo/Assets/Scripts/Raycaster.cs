using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycaster : MonoBehaviour
{
    public Vector2 offset = new Vector2 (0, 1);
    public LayerMask layerMask;


    void FixedUpdate()
    {
        #region Raycast 2D
        /*
        //if you want to change the values of a Vector,you need to change x and y individually
        Vector2 origin = transform.position;
        origin.x = offset.x + transform.position.x;
        origin.y = offset.y + transform.position.y;

        Vector2 customV = new Vector2(2, 1);


        //RaycastHit2D hit = Physics2D.Raycast(origin, Vector2.down);//built in direction
        //RaycastHit2D hit = Physics2D.Raycast(origin, customV); //custom direction
        //RaycastHit2D hit = Physics2D.Raycast(transform.position, -transform.up); //rotate with character
        RaycastHit2D hit = Physics2D.Raycast(transform.position, -transform.up, Mathf.Infinity, layerMask);

        Debug.DrawRay(transform.position, -transform.up * hit.distance, Color.red);

        if(hit.collider != null) //did i hit anything with a collider
        {
            Debug.Log("Hit!");
        }
        */
        #endregion

        #region Raycast (3D)

        /*
        RaycastHit hit;

        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.left), out hit, Mathf.Infinity, layerMask)) 
        {
            Debug.Log("3D Hit!");
        }
        */
        #endregion

        #region CircleCast
        RaycastHit2D hit = Physics2D.CircleCast(transform.position, .5f, -transform.up);

        if (hit.collider != null) //did i hit anything with a collider
        {
            Debug.Log("Hit!");
        }
        #endregion
    }
}
