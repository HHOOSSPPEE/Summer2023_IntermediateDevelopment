using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour
{
    public float volume;
    public Slider volumeSlider;

    public AudioSource musicVolume;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        volume = volumeSlider.value;
        musicVolume.volume = volume;
    }
}
