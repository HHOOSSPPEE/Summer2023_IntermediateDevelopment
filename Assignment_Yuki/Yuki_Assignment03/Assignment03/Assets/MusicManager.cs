using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MusicManager : MonoBehaviour
{

    public float volume;
    //public Slider volumeSlider;

    public AudioSource sceneMusic;

    private GameManager gameManager;

    void Start()
    {
        volume = 0.5f;
        // gameManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();

        //  volume = gameManager.musicVolume;
        //volume = slider.value;
    }

    // Start is called before the first frame update
    /* private void Start()
     * 
     {
         DontDestroyOnLoad(gameObject);
     }
    */


    // Update is called once per frame
    void Update()
    {
        // volume = volumeSlider.value;
        // gameManager.musicVolume = volume;
        //sceneMusic.volume = gameManager.musicVolume;
        sceneMusic.volume = volume;
    }
}
