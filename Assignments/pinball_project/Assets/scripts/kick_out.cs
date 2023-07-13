using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kick_out : MonoBehaviour
{
    public GameObject pinball;
    float timer = 0;
    float hit;
    SpriteRenderer pinball_renderer;


    // Start is called before the first frame update
    void Start()
    {
        GetComponent<PointEffector2D>().enabled = false;
        pinball_renderer = pinball.GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if(GetComponent<PointEffector2D>().enabled == true)
        {
            timer += Time.deltaTime;

        }
        if(timer>3)
        {
            GetComponent<PointEffector2D>().enabled = false;
            timer = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (hit > 0 )
        {
            pinball_renderer.color = Color.white;
            scores.scoreValue -= 10;
            GetComponent<PointEffector2D>().enabled = true;
            hit = 0;
        }
        else
        {
            hit++;
        }
    }
}
