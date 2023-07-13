using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreBoard : MonoBehaviour
{
    public static ScoreBoard instance;


    public TMP_Text scoreText;
    private int scoreNumber;
    public KeyCode startKey;
    private bool startedCounting = false;


    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(startKey)) { startedCounting = true; }
        if (startedCounting) { scoreNumber += 1; }

        scoreText.SetText("" + scoreNumber);
    }

    public void AddThousand()
    {
        scoreNumber += 1000;
        scoreText.SetText("" + scoreNumber);
    }
}
