using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class slider : MonoBehaviour
{
    public MusicManager Manager;
    public UnityEngine.UI.Slider UI_slider;

    public void SoundChangeer()
    {
        //change the volume when valve change
        Manager.volume = UI_slider.value;
    }

   
}
