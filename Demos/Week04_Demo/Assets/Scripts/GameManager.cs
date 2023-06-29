using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float musicVolume;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
    public void SceneChanger(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

}
