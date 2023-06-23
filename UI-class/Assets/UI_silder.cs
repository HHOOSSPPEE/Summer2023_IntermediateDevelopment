using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_silder : MonoBehaviour
{
    public musicMan musicman;
    public Slider musicSlider;

     public void changeVolum()
    { 
        musicman.volume = musicSlider.value;
    }
    
}
