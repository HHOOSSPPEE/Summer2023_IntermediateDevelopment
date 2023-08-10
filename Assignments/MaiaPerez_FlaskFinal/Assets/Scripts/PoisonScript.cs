using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoisonScript : MonoBehaviour
{
    //keep refrences of enemies
    WalkingScript walkingScript;
    private List<Collider2D> enemiesInside = new List<Collider2D>();
    private Vector2 position;
    public float increment;

    void Start()
    {
        position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y);
        StartCoroutine(SelfDestruct());
        StartCoroutine(DownTickStart());
    }

    void Update()
    {
        gameObject.transform.position = position;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<CapsuleCollider2D>() != null)
        {
            enemiesInside.Add(collision);
            if (enemiesInside.Count == 1)
                StartCoroutine(Damage());
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        enemiesInside.Remove(collision);
    }

    IEnumerator Damage()
    {
        foreach (CapsuleCollider2D x in enemiesInside)
        {
            if (x.gameObject == null || x == null)
            {
                enemiesInside.Remove(x);
            }
            else
            {
                x.gameObject.GetComponent<WalkingScript>().health -= 1;
                StartCoroutine(ColorFlash(x));
            }
        }
        yield return new WaitForSeconds(1);
        if (enemiesInside.Count > 0)
        {
            StartCoroutine(Damage());
        }
    }

    IEnumerator ColorFlash(Collider2D x)
    {
        x.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.63f, 0.53f, 0.65f);
        yield return new WaitForSeconds(0.1f);
        x.gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1);
    }

    IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(15);
        Destroy(gameObject);
    }

    IEnumerator DownTickStart()
    {
        yield return new WaitForSeconds(0.5f);
        position.y -= increment;
        StartCoroutine(UpTick());
    }

    IEnumerator UpTick()
    {
        yield return new WaitForSeconds(0.5f);
        position.y += increment;
        yield return new WaitForSeconds(0.5f);
        position.y += increment;
        StartCoroutine(DownTick());

    }

    IEnumerator DownTick()
    {
        yield return new WaitForSeconds(0.5f);
        position.y -= increment;
        yield return new WaitForSeconds(0.5f);
        position.y -= increment;
        StartCoroutine(UpTick());
    }


}
