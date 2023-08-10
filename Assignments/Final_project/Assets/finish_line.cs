using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finish_line : MonoBehaviour
{
    public AudioSource sound_player;
    public AudioClip clip;
    public timer Timer;
    public GameObject Finish;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
  
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            Timer.time_is_running = false;
            Finish.SetActive(true);
            sound_player.PlayOneShot(clip);
        }

    }
}
