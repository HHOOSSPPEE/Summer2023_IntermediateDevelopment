using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class DiedTrigger : MonoBehaviour
{
    private GameObject _player;
    public string sceneName;

    [SerializeField]
    private UnityEvent _collisionEntered;

    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == _player)
        {
            Invoke("Died", 4f);
            Debug.Log("Died");
            _collisionEntered?.Invoke();
        }
    }

    private void Died()
    {
        SceneManager.LoadScene(sceneName);
    }
}
