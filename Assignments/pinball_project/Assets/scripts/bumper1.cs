using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bumper1 : MonoBehaviour
{

    Light lightbumper;
    float wTimer;
    float rTimer;
    SpriteRenderer sprite_renderer;
    [SerializeField] float distanceToCover;
    [SerializeField] float speed;

    private Vector2 startingPosition;

    // Start is called before the first frame update
    void Start()
    {   
        startingPosition= transform.position;
        lightbumper = GetComponent<Light>();
        sprite_renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 v = startingPosition;
        v.x += distanceToCover * Mathf.Sin(Time.time * speed);
        transform.position = v;

        
        if (sprite_renderer.color == Color.grey)
        {
            wTimer += Time.deltaTime;

        }
        if (wTimer > 0.5)
        {

            sprite_renderer.color = Color.white;
            wTimer = 0;


        }



    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (sprite_renderer.color == Color.white)
        {
            sprite_renderer.color = Color.grey;
        }
        scores.scoreValue += 10;
        collision.rigidbody.AddForce(-collision.contacts[0].normal*5,ForceMode2D.Impulse);


    }


}
