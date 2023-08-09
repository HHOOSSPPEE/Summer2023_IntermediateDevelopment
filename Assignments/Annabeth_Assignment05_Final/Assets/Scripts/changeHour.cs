using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class changeHour : MonoBehaviour
{
    public TMP_Text time;
    public bool CC;
    // Start is called before the first frame update
    void Start()
    {
        time = GetComponent<TMP_Text>();
        CC = GameObject.Find("min").GetComponent<ChangeClock>().bedTime;
    }

    // Update is called once per frame
    void Update()
    {
        CC = GameObject.Find("min").GetComponent<ChangeClock>().bedTime;
        if (CC)
        {
            time.text = "10";
        }
        else
        {
            time.text = "09";
        }

    }


}
