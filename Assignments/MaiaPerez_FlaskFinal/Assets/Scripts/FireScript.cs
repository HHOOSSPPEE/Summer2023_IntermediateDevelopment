using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if enemy
        if (collision.gameObject.GetComponent<CapsuleCollider2D>() != null)
        {
            //enemy die
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
