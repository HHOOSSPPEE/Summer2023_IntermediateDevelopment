using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class timer : MonoBehaviour
{
    public float time_remaining = 0;
    public bool time_is_running = true;
    public TMP_Text time_text;
    
    
    // Start is called before the first frame update
    void Start()
    {
        time_is_running = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (time_is_running)
        {
            if (time_remaining>= 0)
            {
                time_remaining += Time.deltaTime;
                DisplayTime(time_remaining);
            }
        }
    }
    void DisplayTime(float time_to_display)
    {
        time_to_display += 1;
        float minutes = Mathf.FloorToInt(time_to_display / 60);
        float seconds = Mathf.FloorToInt(time_to_display % 60);
        time_text.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
}
