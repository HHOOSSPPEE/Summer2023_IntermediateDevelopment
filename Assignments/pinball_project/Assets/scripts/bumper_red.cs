using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bumper_red: MonoBehaviour
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
        if (sprite_renderer.color == Color.red)
        {
            wTimer += Time.deltaTime;

        }
        if (wTimer > 0.5)
        {

            sprite_renderer.color = mycolor;
            wTimer = 0;


        }



    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (sprite_renderer.color == mycolor)
        {
            sprite_renderer.color = Color.red;
        }
        pinball_renderer.color = Color.red;
        scores.scoreValue += 10;
        collision.rigidbody.AddForce(-collision.contacts[0].normal * 5, ForceMode2D.Impulse);


    }


}
