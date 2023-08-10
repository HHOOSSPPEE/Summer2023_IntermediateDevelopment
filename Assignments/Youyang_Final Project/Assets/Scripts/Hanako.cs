using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hanako : MonoBehaviour
{
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public void HanakoTrigger()
    {
        _animator.SetTrigger("Hanako");
    }

    public void DoorOpen()
    {
        _animator.SetTrigger("DoorOpen");
    }
}
