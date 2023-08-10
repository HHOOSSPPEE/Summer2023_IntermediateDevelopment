using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycaster : MonoBehaviour
{

    public Vector2 offset = new Vector2(0, 1);
    public LayerMask layerMask;

    void FixedUpdate()
    {
        Vector2 origin = transform.position;
        origin.x = offset.x + transform.position.x;
        origin.y = offset.y + transform.position.y;

        Vector2 customV = new Vector2(2, 1);

        //RaycastHit2D hit = Physics2D.Raycast(origin, Vector2.down); //built in direction
        //RaycastHit2D hit = Physics2D.Raycast(origin, customV); //custom direction
        //RaycastHit2D hit = Physics2D.Raycast(transform.position, -transform.up); //rotate with sprite
        RaycastHit2D hit = Physics2D.Raycast(transform.position, -transform.up, Mathf.Infinity, layerMask);

        Debug.DrawRay(transform.position, -transform.up, Color.red);

        if (hit.collider != null)
        {
            Debug.Log("hit");
        }

    }


}
