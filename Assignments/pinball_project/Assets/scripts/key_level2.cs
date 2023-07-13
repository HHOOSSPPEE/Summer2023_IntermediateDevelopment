using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key_level2 : MonoBehaviour
{
    public GameObject pinball;
    SpriteRenderer pinball_renderer;
    // Start is called before the first frame update
    void Start()
    {
        pinball_renderer = pinball.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (pinball_renderer.color == Color.yellow)
        {
            Destroy(gameObject);
        }

    }
}
