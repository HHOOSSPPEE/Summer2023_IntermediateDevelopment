using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManger : MonoBehaviour
{
    public float musicVolum;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
    public void SceneChanger(string target)
    {
        SceneManager.LoadScene(target);
    }

}
