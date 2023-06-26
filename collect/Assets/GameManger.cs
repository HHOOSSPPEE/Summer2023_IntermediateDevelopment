using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManger : MonoBehaviour
{
    public float musicVolum;

    private void Start()
    {
        //make sure this gameobject doesn't destory on change scene
        DontDestroyOnLoad(gameObject);
    }
    public void SceneChanger(string target)
    {
        //change sceen code current useless
        SceneManager.LoadScene(target);
    }
}
