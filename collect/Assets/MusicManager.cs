using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Fungus;
using Unity.VisualScripting;

public class MusicManager : MonoBehaviour
{
    public float volume;
    //public Slider volumeSlider;

    public AudioSource musicVolum;

    private GameManger gameManger;

    // Start is called before the first frame update
    void Start()
    {
        //find the gamemanger
        gameManger = GameObject.FindGameObjectWithTag("GameController").
            GetComponent<GameManger>();

        //makesure volume in music manger is same in gamemanger
        volume = gameManger.musicVolum;
    }
    void Update()
    {
        //change the volum in manger
        gameManger.musicVolum = volume;

        //change the volum in game manger
        musicVolum.volume = gameManger.musicVolum;
    }
}
