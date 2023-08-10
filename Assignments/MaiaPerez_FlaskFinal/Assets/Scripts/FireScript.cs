using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<CapsuleCollider2D>() != null)
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
