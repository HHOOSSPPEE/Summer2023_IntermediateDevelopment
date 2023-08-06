using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    public int KnockBarrelFrom;
    // Start is called before the first frame update
    void Start()
    {
        KnockBarrelFrom = -1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Barrel" && Input.GetKeyDown(KeyCode.X))
        {
           if(collision.gameObject.name == "Barrel_P")
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
}
