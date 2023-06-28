using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour
{
    public float volume;
    public Slider volumeSlider;
    public AudioSource sceneMusic;

    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
        volume = 0.5f;
    }

    private void Awake()
    {
        int numMusicManager = FindObjectsOfType<MusicManager>().Length;
        if (numMusicManager != 1)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
       gameManager.musicVolume = volume;
       sceneMusic.volume = gameManager.musicVolume;
    }
}
