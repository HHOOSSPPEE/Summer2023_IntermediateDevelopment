using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public TMP_Text text;
    public Playermove move;

    private void Awake()
    {
        text = GetComponent<TMP_Text>();
        move = GameObject.FindGameObjectWithTag("Player").GetComponent<Playermove>();
    }
    // Update is called once per frame
    void Update()
    {
        text.text = "Life:" + (move.life).ToString();
    }
}
