using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UI_Slider : MonoBehaviour
{
    public MusicManager musicManager;
    public Slider slider;


    public void ChangeVolume()
    {
        musicManager.volume = slider.value;
    }
}
