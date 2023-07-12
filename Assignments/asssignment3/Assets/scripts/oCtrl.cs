using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class oCtrl : MonoBehaviour
{
    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void SceneChanger(string scene)
    {
        SceneManager.LoadScene(scene);
        musicMan.musManInstance.snClick.Play();
        switch (scene)
        {
            case "frogger":
                musicMan.musManInstance.snBase.volume = 0;
                musicMan.musManInstance.snFrogger.volume = 1;
                break;
            case "catter":
                musicMan.musManInstance.snBase.volume = 0;
                musicMan.musManInstance.snCatter.volume = 1;
                break;
            case "polarer":
                musicMan.musManInstance.snBase.volume = 0;
                musicMan.musManInstance.snPander.volume = 1;
                break;
        }
    }
}
