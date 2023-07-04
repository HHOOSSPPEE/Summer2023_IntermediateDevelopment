using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private GameObject player;

    private p_c playercontroller;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playercontroller = player.GetComponent<p_c>();
    }

  

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject == player)
        {
            //playercontroller.playerhealth =- 1;
            //Debug.Log(playercontroller.playerhealth);
            if (playercontroller.canTakedamage == true)
            {
                StartCoroutine(DoDamage());
            }
        }
    }

    IEnumerator DoDamage() 
    { 
        playercontroller.canTakedamage = false;
        playercontroller.playerhealth -= 1;
        yield return new WaitForSeconds(1f);
        playercontroller.canTakedamage = true;

    }
}
