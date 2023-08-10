using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LocateCorrect : MonoBehaviour
{
    private GameObject _player;

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
            Invoke("Correct", 4f);
            _collisionEntered?.Invoke();
        }
    }

    private void Correct()
    {
        _collisionEntered?.Invoke();
    }
}
