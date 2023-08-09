using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetEnding : MonoBehaviour
{
    private string RI_M;
    private string RI_D;
    private string RI_R;
    private string RI_N;

    private bool Rick_Collide;
    private bool Nick_Collide;

    private bool Mom_move;
   //private bool Dad_move;

    public GameObject alarm;

    public float timer;
    public bool end;
    private bool endReached;

    // Start is called before the first frame update
    void Start()
    {
        end = false;
        RI_M = GameObject.Find("Mom").GetComponent<RoomIndicator>().room;
        RI_D = GameObject.Find("Dad").GetComponent<RoomIndicator>().room;
        RI_R = GameObject.Find("Rick").GetComponent<RoomIndicator>().room;
        RI_N = GameObject.Find("Nick").GetComponent<RoomIndicator>().room;

        Rick_Collide = GameObject.Find("Rick").GetComponent<CollectObjects>().colliding;
        Nick_Collide = GameObject.Find("Nick").GetComponent<CollectObjects>().colliding;

        Mom_move = GameObject.Find("Mom").GetComponent<WayPointsManager>().changed;

        endReached = false;
    }

    // Update is called once per frame
    void Update()
    {
        RI_M = GameObject.Find("Mom").GetComponent<RoomIndicator>().room;
        RI_D = GameObject.Find("Dad").GetComponent<RoomIndicator>().room;
        RI_R = GameObject.Find("Rick").GetComponent<RoomIndicator>().room;
        RI_N = GameObject.Find("Nick").GetComponent<RoomIndicator>().room;

        Rick_Collide = GameObject.Find("Rick").GetComponent<CollectObjects>().colliding;
        Nick_Collide = GameObject.Find("Nick").GetComponent<CollectObjects>().colliding;

        Mom_move = GameObject.Find("Mom").GetComponent<WayPointsManager>().changed;
        print("MOM" + RI_M + " dad" + RI_D + " Rick" + RI_R + " Nick" + RI_N);
        
        if (!Mom_move && !endReached)
        {
            //print("mom noyt move");
            if ((RI_R == RI_M || RI_R == RI_D) && Rick_Collide)
            {
                print("a" + (RI_R == RI_M || RI_R == RI_D));
                alarm.SetActive(true);
                timer += Time.deltaTime;
            }else if ((RI_N == RI_M || RI_N == RI_D) && Nick_Collide)
            {
                alarm.SetActive(true);
                timer += Time.deltaTime;
                print("b" + (RI_N == RI_M || RI_N == RI_D));
            }
            else
            {
                alarm.SetActive(false);
                timer = 0;
            }
            
        }
        else
        {
            alarm.SetActive(false);
            timer = 0;
        }

        if(timer >= 2)
        {
            endReached = true;
            print("end");
            end = true;
        }

    }
}
