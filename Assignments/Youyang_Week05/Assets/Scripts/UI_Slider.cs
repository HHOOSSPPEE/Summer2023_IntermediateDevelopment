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
        //musicManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeVolume()
    {
        musicManager.volume = slider.value;
    }
}
