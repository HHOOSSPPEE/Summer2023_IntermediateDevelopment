using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingScript : MonoBehaviour
{

    public Animator anim;
    private bool visible = true;
    public int health = 10;
    private int direction = -1;
 
    void Start()
    {
        anim.SetBool("gameStart", true);
    }

    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    void Walk()
    {
        gameObject.transform.GetChild(0).gameObject.SetActive(visible);
        visible = !visible;
        if (gameObject.tag == "Scientist")
        {
            transform.Translate(-1, 0, 0);
        }
        else if (gameObject.tag == "Biologist")
        {
            transform.Translate(-1, direction, 0);
            direction *= -1;
        }
        else if (gameObject.tag == "Physicist")
        {
            transform.Translate(-1, 0, 0);
        }
    }

    
}
