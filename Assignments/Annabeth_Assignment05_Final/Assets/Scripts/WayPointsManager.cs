using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointsManager : MonoBehaviour
{
    public GameObject person;
    public GameObject[] Parlor;
    public GameObject[] Hall;
    public GameObject[] MasterBedroom;
    public GameObject[] Kitchen;
    public GameObject[] Bedroom;
    private List<GameObject[]> Places = new List<GameObject[]>();
    private int count = 0;
    private int place = 0;
    private bool finishRoom;

    public GameObject Collision;
    public int Rick;
    public int Nick;
    public int roomNum;
    public int roomNum_temp;
    public int roomNum_temp_R;
    public int roomNum_temp_N;
    public bool change;

    public int currentRoom;

    public float speed = 2f;

    // Start is called before the first frame update
    void Start()
    {


        Places.Add(Parlor);
        Places.Add(Hall);
        Places.Add(MasterBedroom);
        Places.Add(Kitchen);
        Places.Add(Bedroom);
        transform.position = Places[0][0].transform.position;
        finishRoom = true;
        roomNum = -1;
        roomNum_temp = -1 ;
        roomNum_temp_N = -1;
        roomNum_temp_R = -1;
        currentRoom = -1;


    }

    // Update is called once per frame
    void Update()
    {
        Rick = GameObject.Find("Rick").GetComponent<Collisions>().KnockBarrelFrom;
        Nick = GameObject.Find("Nick").GetComponent<Collisions>().KnockBarrelFrom;
        change = GameObject.Find("Nick").GetComponent<Collisions>().changed;
        TourLoop();
    }

    public void TourLoop()
    {
        if (finishRoom) 
        {
            if(roomNum_temp != -1 && roomNum == 0)
            {
                place = roomNum_temp;
                roomNum = -1;
            }
            else
            {
                place = Random.Range(0, Places.Count);
            }
            finishRoom = false;            
        }
        Tour(person, speed, place);

    }

    public void Tour(GameObject person, float speed, int place)
    {
        //now
        //print("Rick: " + roomNum_temp_R + " Nick " + roomNum_temp_N + " Picked: "+ roomNum_temp);
        if (roomNum == -1 && (!change && Rick != roomNum_temp && Rick != -1 || change && Nick != roomNum_temp && Nick != -1))
        {
            if(Rick != roomNum_temp_R && Rick != -1)
            {
                roomNum_temp_R = Rick;
            }
            if(Nick != roomNum_temp_N && Nick != -1)
            {
                roomNum_temp_N = Nick;
            }
            if(roomNum_temp_R != roomNum_temp && roomNum_temp_R != -1)
            {
                roomNum_temp = roomNum_temp_R;
            }else if(roomNum_temp_N != roomNum_temp && roomNum_temp_N != -1)
            {
                roomNum_temp = roomNum_temp_N;
            }
            //roomNum_temp = (roomNum_temp_R != place) ? roomNum_temp_R : roomNum_temp_N;


            if(place == 0)//parlor
            {
                count = 6;
            }else if (place == 1)//hall
            {
                finishRoom = true;
                count = 0;
            }
            else if (place == 2)//masterbedroom
            {
                
                if(count <= 3)
                {
                    count = 15;
                }
                else
                {
                    count = 13;
                }
                
            }else if (place == 3)//kitchen
            {
                if (count <= 3)
                {
                    count = 11;
                }
                else
                {
                    count = 9;
                }
                
            }else if (place == 4)//bedroom
            {
                count = 8;
            }
            //finishRoom = true;
            //count = 0;
            roomNum = 0;
        }
        //print("score:" + count + " place" + place + "me: " +person.transform.position + " other: " +Places[place][count].transform.position);
        person.transform.position = Vector3.MoveTowards(person.transform.position, Places[place][count].transform.position, speed * Time.deltaTime);
        if (person.transform.position == Places[place][count].transform.position)
        {
            count++;
            //currentRoom = place;

        }
        //loop
        if (count >= Places[place].Length)
        {
            count = 0;
            finishRoom = true;
        }
    }

    public void countBack()
    {
        count = 0;
    }
}
