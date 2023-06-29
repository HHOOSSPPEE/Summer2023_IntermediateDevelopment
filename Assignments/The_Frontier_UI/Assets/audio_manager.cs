using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class audio_manager : MonoBehaviour
{

    public float volume;
    public Slider volumeSlider;

    public AudioSource musicVolume;

    private game_manager game_manager;

    // Start is called before the first frame update
    void Start()
    {
        game_manager = GameObject.FindGameObjectWithTag("GameController").GetComponent<game_manager>();

        volume = game_manager.musicVolume;

    }

    // Update is called once per frame
    void Update()
    {
        volume = volumeSlider.value;
        game_manager.musicVolume = volume;

        musicVolume.volume = game_manager.musicVolume;
    }

}
