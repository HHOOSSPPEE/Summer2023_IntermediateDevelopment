using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.UIElements;

public class NoTutorial : MonoBehaviour
{
    public GameManager GM;
    public GameObject tutorial;
    public GameObject clock;
    public GameObject game;
    public GameObject invent;

    public Button start;

    // Start is called before the first frame update
    void Start()
    {
        start.onClick.AddListener(onClick); 
        GM = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    public void onClick()
    {
        //print(GameManager.reload) ;
        if (GameManager.reload == true)
        {
            game.SetActive(true);
            invent.SetActive(true);
            clock.SetActive(true);
        }
        else
        {
            tutorial.SetActive(true);
        }
    }
}
