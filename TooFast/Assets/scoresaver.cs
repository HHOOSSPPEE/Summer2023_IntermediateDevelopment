using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoresaver : MonoBehaviour
{
    public float score;
    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
}
