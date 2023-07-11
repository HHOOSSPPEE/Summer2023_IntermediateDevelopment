using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sew : MonoBehaviour
{
    public bool isGrey = false;
    private float x;
    private float y;

    // Start is called before the first frame update
    void Start()
    {
        x = this.transform.position.x;
        y = this.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (isGrey == true)
        {
            Debug.Log("111");
            this.gameObject.GetComponent<Renderer>().material.color = Color.gray;
            this.gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
            transform.position = new Vector3(x, y, 0);

        }
        else
        {
            Debug.Log("222");
            this.gameObject.GetComponent<Renderer>().material.color = Color.white;
            this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;

        }
    }
}
