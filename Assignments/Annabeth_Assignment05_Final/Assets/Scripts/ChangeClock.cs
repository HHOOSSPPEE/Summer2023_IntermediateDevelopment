using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChangeClock : MonoBehaviour
{

    public TMP_Text time;
    private int factor = 10;
    public int min;
    public float minNotRounded = 0;
    private int digit;
    public bool bedTime = false;
    
    // Start is called before the first frame update
    void Start()
    {
        min = 30;
        time = GetComponent<TMP_Text>();
        time.text = min.ToString();
        digit = factor;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (!bedTime)
        {
            minNotRounded += (Time.deltaTime);
        }
        
        if (minNotRounded >= digit)
        {
            
            min += 1;
            time.text = min.ToString();
            digit += factor;
        }

        if(min > 59)
        {
            bedTime = true;
            time.text = "00";
        }

    }
}