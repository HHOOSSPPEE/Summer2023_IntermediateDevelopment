using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Fungus;
using Unity.VisualScripting;

public class musicMan : MonoBehaviour
{
    public float volume;
    //public Slider volumeSlider;

    public AudioSource musicVolum;

    private GameManger gameManger;

    // Start is called before the first frame update
    void Start()
    {
        gameManger = GameObject.FindGameObjectWithTag("GameController").
            GetComponent<GameManger>();

        volume = gameManger.musicVolum;
    }

    // Update is called once per frame
    void Update()
    {
       // volume = volumeSlider.value;
        //musicVolum.volume = volume;
        gameManger.musicVolum = volume;

        musicVolum.volume = gameManger.musicVolum;
    }
}
