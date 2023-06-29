using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MusicManager : MonoBehaviour
{
    public float volume;
    //public Slider volumeSlider;

    public AudioSource sceneMusic;

    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameController").
            GetComponent<GameManager>();

        volume = gameManager.musicVolume;
    }

    // Update is called once per frame
    void Update()
    {
        //volume = volumeSlider.value;
        gameManager.musicVolume = volume;
        sceneMusic.volume = gameManager.musicVolume;
    }
}
