using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformClock : MonoBehaviour
{
    CanvasGroup canvasGroup;
    public Vector3 invent;
    public Vector3 origin;
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
        transform.position = transform.position - new Vector3(1000, 0, 0);
    }

    public void turnClockOn()
    {
        transform.position = transform.position + new Vector3(1000, 0, 0);
        //transform.position = origin;
        //canvasGroup.alpha = 1f;
        //canvasGroup.blocksRaycasts = true;
        //GetComponent<CanvasRenderer>().cull = true;
    }
}
