using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

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
          
            this.gameObject.GetComponent<Renderer>().material.color = Color.gray;
            this.gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
            transform.position = new Vector3(x, y, 0);

            this.gameObject.GetComponentInChildren<Renderer>().material.color = Color.gray;

            

        }
        else
        {
            
            this.gameObject.GetComponent<Renderer>().material.color = Color.white;
            this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;

            this.gameObject.GetComponentInChildren<Renderer>().material.color = Color.white;

            
        }

       
    }
}
