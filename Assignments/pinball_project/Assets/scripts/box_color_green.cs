using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box_color_green : MonoBehaviour
{
    public GameObject pinball;
    public Color mycolor;
    Light lightbumper;
    float wTimer;
    float rTimer;
    SpriteRenderer sprite_renderer;
    SpriteRenderer pinball_renderer;

    // Start is called before the first frame update
    void Start()
    {
        sprite_renderer = GetComponent<SpriteRenderer>();
        pinball_renderer = pinball.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (sprite_renderer.color == Color.green)
        {
            wTimer += Time.deltaTime;

        }
        if (wTimer > 0.5)
        {

            sprite_renderer.color = mycolor;
            wTimer = 0;


        }



    }

    private void OnTriggerEnter2D(Collider2D collision)
    { 
        if (sprite_renderer.color == mycolor)
        {
            sprite_renderer.color = Color.green;
        }
        pinball_renderer.color = Color.green;
      


    }
}
