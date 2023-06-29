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
    // Start is called before the first frame update
    public void SceneChanger(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        SceneManager.LoadScene(sceneName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
