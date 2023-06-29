using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class game_manager : MonoBehaviour
{
    public float musicVolume;
    private void Start()
    {
        DontDestroyOnLoad(this);
    }


    public void SceneChanger(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
