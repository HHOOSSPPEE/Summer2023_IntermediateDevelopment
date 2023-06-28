using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlay : MonoBehaviour
{
    public AudioSource sceneMusic;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        sceneMusic.volume = gameManager.musicVolume;
    }
}
