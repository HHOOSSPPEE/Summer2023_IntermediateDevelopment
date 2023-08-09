using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformClock : MonoBehaviour
{
    CanvasGroup canvasGroup;
    public Vector3 invent = new Vector3(-251, 182, 0);
    public Vector3 origin = new Vector3(1074.094f, 654.1316f, 0);
    public Vector3 offset;
    //Vector3 3 -110.6049

    // Start is called before the first frame update
    void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        origin = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void turnClockOff()
    {
        transform.position = invent;
        //canvasGroup.alpha = 0f; 
        //canvasGroup.blocksRaycasts = false; 
        //GetComponent<CanvasRenderer>().cull = false;
    }

    public void turnClockOn()
    {
        transform.position = origin;
        //canvasGroup.alpha = 1f;
        //canvasGroup.blocksRaycasts = true;
        //GetComponent<CanvasRenderer>().cull = true;
    }
}
