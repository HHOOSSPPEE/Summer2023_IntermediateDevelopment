using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ice_sew : MonoBehaviour
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
            //change the gameobject into trigger and change it's color
            this.gameObject.GetComponent<Renderer>().material.color = Color.gray;
            this.gameObject.GetComponent<PolygonCollider2D>().isTrigger = true;
            transform.position = new Vector3(x, y, 0);

            this.gameObject.GetComponentInChildren<Renderer>().material.color = Color.gray;



        }
        else
        {
            //change back gameobject from trigger and change it's color
            this.gameObject.GetComponent<Renderer>().material.color = Color.white;
            this.gameObject.GetComponent<PolygonCollider2D>().isTrigger = false;

            this.gameObject.GetComponentInChildren<Renderer>().material.color = Color.white;


        }


    }
}
