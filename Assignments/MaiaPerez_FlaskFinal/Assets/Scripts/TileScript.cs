using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour
{
    public BigBottleScript bbscrip; 

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
