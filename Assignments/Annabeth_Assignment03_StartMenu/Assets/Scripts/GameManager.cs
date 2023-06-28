using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float musicVolume;
    public float SEVolume;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    //private void Awake()
    //{
    //    int numGameManager = FindObjectsOfType<GameManager>().Length;
    //    if (numGameManager != 1)
    //    {
    //        Destroy(this.gameObject);
    //    }
    //    else
    //    {
    //        DontDestroyOnLoad(gameObject);
    //    }
    //}

    public void SceneChanger(string sceneName)
    {
        StartCoroutine(DelaySceneLoad(sceneName));
        //SceneManager.LoadScene(sceneName);
    }

    IEnumerator DelaySceneLoad(string sceneName)
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(sceneName);
    }
}
