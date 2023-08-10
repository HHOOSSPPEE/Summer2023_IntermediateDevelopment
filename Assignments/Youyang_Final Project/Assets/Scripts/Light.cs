using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour
{
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public void LightOff()
    {
        _animator.SetTrigger("LightOff");
    }

    public void LightDied()
    {
        _animator.SetTrigger("LightDied");
    }
}
