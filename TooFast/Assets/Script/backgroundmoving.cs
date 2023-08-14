using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundmoving : MonoBehaviour
{
    public float speed = 4f;
    private Vector3 StartPos;
    public float speeddown; 
    public SpeedManger speedManger;

    private void Awake()
    {
        speedManger = GameObject.FindObjectOfType<SpeedManger>().GetComponent<SpeedManger>();
    }

    // Start is called before the first frame update
    void Start()
    {
        //set the start Pos
        StartPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //change the moving speed of the bg
        if (speeddown <= 5)
        {
            speeddown = speedManger.Speedmult * 10 + 1;
        }
        //move the bg
        transform.Translate(translation:Vector3.down*speed*Time.deltaTime * speeddown);
        //reset the bg
        if (transform.position.y < -55)
        {
            transform.position = StartPos;
        }
    }

    
}
