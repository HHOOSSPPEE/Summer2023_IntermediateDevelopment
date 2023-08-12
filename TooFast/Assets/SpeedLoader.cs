using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpeedLoader : MonoBehaviour
{
    public TMP_Text text;
    public SpeedManger speedManger;

    private void Awake()
    {
        text = GetComponent<TMP_Text>();
        speedManger = GameObject.FindObjectOfType<SpeedManger>().GetComponent<SpeedManger>();
    }
    // Update is called once per frame
    void Update()
    {
        //showing the speed
        text.text = "Speed:"+ (speedManger.Speedmult * 10).ToString();
    }
}
