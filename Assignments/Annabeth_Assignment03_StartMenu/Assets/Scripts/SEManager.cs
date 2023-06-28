using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SEManager : MonoBehaviour
{
    public float volume;
    public Slider volumeSlider;

    public AudioSource sceneSE;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
        volume = gameManager.SEVolume;
    }

    // Update is called once per frame
    void Update()
    {
        gameManager.SEVolume = volume;
        sceneSE.volume = gameManager.SEVolume;
    }
}
