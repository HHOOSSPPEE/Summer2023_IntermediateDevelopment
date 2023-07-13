using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class collision_sound : MonoBehaviour
{
    public AudioSource sound;
    private float wTimer;
    // Start is called before the first frame update
    void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
       if (wTimer > 0)
        {
            wTimer -= Time.deltaTime;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (sound != null && wTimer <= 0)
        {
            wTimer = 0.5f;
            sound.Play();
        }
    }
}
