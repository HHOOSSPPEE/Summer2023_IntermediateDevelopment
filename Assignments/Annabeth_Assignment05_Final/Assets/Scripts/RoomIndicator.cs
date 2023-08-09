using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomIndicator : MonoBehaviour
{
    public bool master;
    public bool bedroom;
    public bool kitchen;
    public bool parlor;
    public bool hall;

    public string room;
    // Start is called before the first frame update
    void Start()
    {
        master = false;
        bedroom = false;
        kitchen = false;
        parlor = false;
        hall = true;
        room = "hall";
    }

    // Update is called once per frame
    void Update()
    {
        if (master)
        {
            room = "master";
        }else if (bedroom)
        {
            room = "bedroom";
        }else if (kitchen)
        {
            room = "kitchen";
        }else if (parlor)
        {
            room = "parlor";
        }
        else
        {
            room = "hall";
        }
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Door")
        {
            if(collision.gameObject.name == "Door_M")
            {
                if (master)
                {
                    room = "master";
                    master = false;
                    hall = true;
                }
                else
                {
                    room = "hall";
                    master = true;
                    hall = false;
                }
                
            }
            else if(collision.gameObject.name == "Door_P")
            {
                if (parlor)
                {
                    room = "parlor";
                    parlor = false;
                    hall = true;
                }
                else
                {
                    room = "hall";
                    parlor = true;
                    hall = false;
                }
            }
            else if (collision.gameObject.name == "Door_B")
            {
                if (bedroom)
                {
                    room = "bedroom";
                    bedroom = false;
                    hall = true;
                }
                else
                {
                    room = "hall";
                    bedroom = true;
                    hall = false;
                }
            }
            else if (collision.gameObject.name == "Door_K")
            {
                if (kitchen)
                {
                    room = "kitchen";
                    kitchen = false;
                    hall = true;
                }
                else
                {
                    room = "hall";
                    kitchen = true;
                    hall = false;
                }
            }
        }
    }
}
