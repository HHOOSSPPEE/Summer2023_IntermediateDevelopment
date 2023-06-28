using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void SceneChange(string sceneName)
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
