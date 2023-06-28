using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_SliderSE : MonoBehaviour
{
    public SEManager seManager;
    public Slider slider;

    public void ChangeVolume()
    {
        seManager.volume = slider.value;
    }
}
