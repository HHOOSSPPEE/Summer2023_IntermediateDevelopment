using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sink : MonoBehaviour
{
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    [ContextMenu("Cover")]
    public void Cover()
    {
        _animator.SetTrigger("Cover");
    }

    public void Died()
    {
        _animator.SetTrigger("Uncover");
    }
}
