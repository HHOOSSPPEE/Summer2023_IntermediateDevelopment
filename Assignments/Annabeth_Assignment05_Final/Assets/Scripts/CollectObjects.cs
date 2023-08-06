using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectObjects : MonoBehaviour
{

    public GameObject cross, marry, boxKey;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.layer == 7)
        {
            //parlor
            if (collision.gameObject.name == "MarriageRecord")
            {
                boxKey.SetActive(true);
            }
            if (collision.gameObject.name == "BoxKey")
            {
                print("key");
            }
            if (collision.gameObject.tag == "Empty")
            {
                print("EMPTY");
            }
        }

    }
}