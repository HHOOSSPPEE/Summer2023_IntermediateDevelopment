using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SecondWind : MonoBehaviour
{
    public Playermove playermove;
    
    public Slider slider;

    public CanvasGroup canvasGroup;

    private void Awake()
    {
        playermove = GameObject.FindGameObjectWithTag("Player").GetComponent<Playermove>();
        slider = GetComponent<Slider>();
        canvasGroup = GetComponent<CanvasGroup>();
    }

    private void Start()
    {
        canvasGroup.alpha = 0.0f;
    }
    public void Still()
    {
        slider.value += 150;
    }

    // Update is called once per frame
    void Update()
    {
        if (playermove.life < 0)
        {
            canvasGroup.alpha = 1f;
            slider.value--;
        }
        if (slider.value == 0)
        {
            SceneManager.LoadScene("End");
        }
    }
}
