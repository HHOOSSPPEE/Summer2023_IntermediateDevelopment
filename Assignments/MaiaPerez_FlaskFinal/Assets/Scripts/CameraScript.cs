using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    
    private Vector3 target;
    private Vector3 origin;
    private bool timeToMove = false;
    private bool hasMoved = false;
    public Transform trans;
    public float speed = 3.0f;
    public int waitTimeSecs = 2;
    public bool startSpawner = true;

    void Start()
    {
        origin = trans.position;
        origin.x -= 1;
        target = new Vector3(17, 0, -10);
        StartCoroutine(PanControl());
    }

    void Update()
    {
        if (timeToMove)
        {
            if (hasMoved)
            {
               trans.position = Vector3.Lerp(transform.position, origin, speed * Time.deltaTime);
                 //Debug.Log("Back");
               if (transform.position.x-1 <= origin.x)
                {
                    //Debug.Log("Stopping");
                    timeToMove = false;
                    GameObject.Find("NonPerma UI").transform.GetChild(0).gameObject.SetActive(true);
                    startSpawner = true;
                }
            }
            else if (!hasMoved) {
                trans.position = Vector3.Lerp(transform.position, target, speed * Time.deltaTime);
                 //Debug.Log("Forward");
                if (trans.position.x+1 >= target.x)
                {
                    //Debug.Log("Switching");
                    hasMoved = true;
                    timeToMove = false;
                    waitTimeSecs -= 1;
                    StartCoroutine(PanControl());
                }
            }
         
        }
    }

    IEnumerator PanControl()
    {
        yield return new WaitForSeconds(waitTimeSecs);
        timeToMove = true;
        //Debug.Log("Here!!!");
    }


}
