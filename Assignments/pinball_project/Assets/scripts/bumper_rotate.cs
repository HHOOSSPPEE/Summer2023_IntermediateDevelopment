using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bumper_rotate : MonoBehaviour
{

    Light lightbumper;
    float wTimer;
    float rTimer;
    SpriteRenderer sprite_renderer;

    // Start is called before the first frame update
    void Start()
    {

        sprite_renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
 



    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        scores.scoreValue += 30;
        collision.rigidbody.AddForce(-collision.contacts[0].normal*2,ForceMode2D.Impulse);


    }


}
