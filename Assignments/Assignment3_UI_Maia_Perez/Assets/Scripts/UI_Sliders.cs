using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Sliders : MonoBehaviour
{
    public MusicManager musicManager;
    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        //musicManager = GameObject.FindGameObjectWithTag("MusicManager").GetComponent<>();
    }

    public void ChangeVolume()
    {
        musicManager.volume = slider.value;
    }
}
