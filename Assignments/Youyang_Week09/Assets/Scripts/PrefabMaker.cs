using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabMaker : MonoBehaviour
{
    public GameObject prefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, new Vector3((Random.Range(-5, 15)), (Random.Range(-8, 3)), 0), Quaternion.identity,transform);
        }

    }
}
