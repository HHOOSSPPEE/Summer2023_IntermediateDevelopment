using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    public int KnockBarrelFrom;
    private bool subChanged;
    public bool changed;

    public bool GM;
    // Start is called before the first frame update
    void Start()
    {
        KnockBarrelFrom = -1;
        //true == nick
        GM = GameObject.Find("GameManager").GetComponent<GameManager>().characterChange;
    }

    // Update is called once per frame
    void Update()
    {
        GM = GameObject.Find("GameManager").GetComponent<GameManager>().characterChange;
    }


    public void OnTriggerStay2D(Collider2D collision)
    {
       
        if (collision.gameObject.tag == "Barrel" && Input.GetKey("space"))
        {
            print("yes");
            if (GM)
            {
                changed = true;
            }
            else
            {
                changed = false;
            }
            if (collision.gameObject.name == "Barrel_P1" || collision.gameObject.name == "Barrel_P2")
            {
                KnockBarrelFrom = 0;
            }
            else if (collision.gameObject.name == "Barrel_H")
            {
                KnockBarrelFrom = 1;
                
            }
            else if (collision.gameObject.name == "Barrel_M")
            {
                KnockBarrelFrom = 2;
            }
            else if (collision.gameObject.name == "Barrel_K")
            {
                KnockBarrelFrom = 3;
                //print(KnockBarrelFrom);
            }
            else if (collision.gameObject.name == "Barrel_B")
            {
                KnockBarrelFrom = 4;
            }

        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        KnockBarrelFrom = -1;
    }

}
