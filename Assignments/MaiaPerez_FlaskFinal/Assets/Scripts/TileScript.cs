using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour
{
    public BigBottleScript bbscrip;
    //sends the big bottle script the coordinates of the the tile that was hovered over
    //if nothing is being hovered over currently, it will send big bottle back to it's origin

    public void OnMouseEnter()
    {
        if (bbscrip.dragging)
        {
            bbscrip.snapLocation = gameObject.transform.position;
        }
    }
    public void OnMouseExit()
    {
        if (bbscrip.dragging)
        {
            bbscrip.snapLocation = bbscrip.origin;
        }
    }

}
