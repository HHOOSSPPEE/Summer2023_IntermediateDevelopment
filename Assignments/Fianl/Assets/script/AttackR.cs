using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackR : MonoBehaviour
{
    public float timeRemaining = 1;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.tag = "Attack";
    }


    private void Update()
    {
        if (timeRemaining <= 0)
        {
            Destroy(gameObject);
            timeRemaining = 3;
        }
        else
        {
            timeRemaining -= Time.deltaTime;
        }
    }
}
