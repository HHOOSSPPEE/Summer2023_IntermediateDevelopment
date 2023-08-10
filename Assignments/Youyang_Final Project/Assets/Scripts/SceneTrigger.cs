using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTrigger : MonoBehaviour
{
    private GameObject _player;
    public string sceneName;

    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == _player)
        {
            SceneManager.LoadScene(sceneName);
            Debug.Log("Change");
        }
    }
}
