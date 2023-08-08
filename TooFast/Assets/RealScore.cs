using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RealScore : MonoBehaviour
{
    public TMP_Text text;
    public scoresaver scoresaver;

    private void Awake()
    {
        text = GetComponent<TMP_Text>();
        scoresaver = GameObject.FindGameObjectWithTag("Score").GetComponent<scoresaver>();
    }
    // Update is called once per frame
    void Update()
    {
        
        text.text = "Score:" + (scoresaver.score).ToString();
    }
}
