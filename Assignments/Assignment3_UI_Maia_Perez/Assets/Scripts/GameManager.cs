using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TMP_Text : MonoBehaviour
{

    public float musicVolume;

    public TMP_InputField inputField;
    public string playerName;


    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void SceneChanger(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
   
    }
    public void SetName()
    {
        playerName = inputField.text;
    }
}
