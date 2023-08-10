using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DontHear : MonoBehaviour
{
    [SerializeField]
    private UnityEvent _collisionEntered;

    public void Tap()
    {
        _collisionEntered?.Invoke();
    }
}
