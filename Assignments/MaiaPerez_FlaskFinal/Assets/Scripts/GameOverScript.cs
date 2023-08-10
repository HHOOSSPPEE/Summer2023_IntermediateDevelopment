using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //ends the game when an enemy hits
        if (collision.gameObject.GetComponent<CapsuleCollider2D>() != null){
            collision.gameObject.GetComponent<Animator>().SetBool("gameStart", false);
            GameObject.Find("NonPerma UI").transform.GetChild(0).gameObject.SetActive(false);
            GameObject.Find("LoseUI").transform.GetChild(0).gameObject.SetActive(true);
        }
    }
}
