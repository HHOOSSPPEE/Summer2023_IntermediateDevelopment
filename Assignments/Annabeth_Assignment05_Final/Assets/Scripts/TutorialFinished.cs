using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialFinished : MonoBehaviour
{
    public GameObject game;
    public GameObject tutorial;
    public GameObject clock;
    public GameObject invent;
    public bool start;
    // Start is called before the first frame update
    void Start()
    {
        start = GameObject.Find("Main Camera").GetComponent<CameraController>().tutorialOver = true;
        game.SetActive(true);
        invent.SetActive(true);
        clock.SetActive(true);
        tutorial.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
