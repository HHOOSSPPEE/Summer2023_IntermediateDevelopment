using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public void FireStart()
    {
        _animator.SetTrigger("FireStart");
        Invoke("FireEnd", 4f);
    }

    /*public void FireEnd()
    {
        _animator.SetTrigger("FireEnd");
    }*/
}
