using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ui_slider : MonoBehaviour
{
    public audio_manager audio_manager;
    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeVolume()
    {
        audio_manager.volume = slider.value;
    }
}
