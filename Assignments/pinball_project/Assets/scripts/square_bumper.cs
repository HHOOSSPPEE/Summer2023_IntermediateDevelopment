using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class square_bumper: MonoBehaviour
{
    public GameObject pinball;
    public Color mycolor;
    Light lightbumper;
    float wTimer;
    float rTimer;
    SpriteRenderer sprite_renderer;
    SpriteRenderer pinball_renderer;

    private int currentColorIndex = 0;
    private int targetColorIndex = 1;
    private float targetPoint;
    public float time;
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
        Color newColor = new Color(Random.value,Random.value,Random.value);
        sprite_renderer.color = newColor;
        scores.scoreValue += 10;
        collision.rigidbody.AddForce(-collision.contacts[0].normal * 1, ForceMode2D.Impulse);


    }


}
