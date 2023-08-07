using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject prefab;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        { 
            Instantiate(prefab, new Vector3((Random.Range(0,10)),(Random.Range(0,10)),0f),Quaternion.identity);
        }
    }
}
