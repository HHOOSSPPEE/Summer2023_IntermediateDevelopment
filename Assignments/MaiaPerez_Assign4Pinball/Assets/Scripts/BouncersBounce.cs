using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncersBounce : MonoBehaviour
{
    public GameObject bouncer;
    private CircleCollider2D circleCollider;
    private Vector2 startSize, smallSize, increaseAmount, currentSize;
    private bool smaller = false;
    public AudioSource boingSound;

    // Start is called before the first frame update
    void Start()
    {
        startSize = new Vector2(bouncer.transform.localScale.x, bouncer.transform.localScale.y);
        smallSize = new Vector2(bouncer.transform.localScale.x*0.75f, bouncer.transform.localScale.y*0.75f);
        circleCollider = bouncer.GetComponent<CircleCollider2D>();
        currentSize = startSize;
        increaseAmount = new Vector2(0.005f, 0.005f);
    }

    // Update is called once per frame
    void Update()
    {
       if (currentSize == startSize) { smaller = false; }
       if (smaller) { currentSize += increaseAmount; }
       bouncer.transform.localScale = currentSize;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        bouncer.transform.localScale = smallSize;
        smaller = true;
        currentSize = smallSize;
        ScoreBoard.instance.AddThousand();
        boingSound.Play();
    }
}
