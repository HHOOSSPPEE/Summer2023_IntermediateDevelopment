using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPeg : MonoBehaviour
{
    public GameObject PegPrefab;
    public float pegSpeed = 10;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var peg = Instantiate(PegPrefab, transform.position, Quaternion.identity);
            peg.GetComponent<Rigidbody2D>().velocity = transform.up * pegSpeed;
            //peg.GetComponent<Rigidbody2D>().AddForce = (new Vector3(0, 30, 0));
            //doesnt work
            
        }
    }

    public void SpawnIt()
    {//generate ball at the position of mouse
        //Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //Vector3 offset = new Vector3(0, 0, 30);
        //var peg =Instantiate(PegPrefab, transform.position, Quaternion.identity);
       // peg.GetComponent<Rigidbody2D>().velocity = transform.up*pegSpeed;
        
    }
}
