using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if enemy
        if (collision.gameObject.GetComponent<CapsuleCollider2D>() != null)
        {   //freeze
            collision.gameObject.GetComponent<Animator>().SetBool("gameStart", false);
            StartCoroutine(BeStuck(collision));
        }
    }

    IEnumerator BeStuck(Collider2D collision)
    { //for 8 secs
        yield return new WaitForSeconds(8);
        collision.gameObject.GetComponent<Animator>().SetBool("gameStart", true);
    }
}
