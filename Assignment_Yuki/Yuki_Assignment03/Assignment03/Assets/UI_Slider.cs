using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UI_Slider : MonoBehaviour
{

    public MusicManager musicManager;
    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
       // musicManager.volume = slider.value;
        //music = GameObject.FindGameObjectWithTag("MusicManager").GetComponent<MusicManager>();
    }


  
    public void ChangeVolume()
    {
        musicManager.volume = slider.value;
    }
}
