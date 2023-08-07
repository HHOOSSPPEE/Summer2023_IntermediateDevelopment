using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thoughtBubbleFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    private Vector3 _pos;

    private float _xpos;
    private float _ypos;
    public GameManager GM;

    // Start is called before the first frame update
    void Start()
    {

        //transform.position = new Vector3(-3.5f, 5, offset.z);
    }


    // Update is called once per frame
    void Update()
    {

        if (GM.characterChange)
        {
            target = GameObject.Find("Nick").GetComponent<Transform>();
        }
        else
        {
            target = GameObject.Find("Rick").GetComponent<Transform>();
        }
        _xpos = target.position.x + offset.x;
        _ypos = target.position.y + offset.y;


        //if (transform.position.x + offset.x <= 3.5 && transform.position.x + offset.x >= -10)
        //{
        //    _xpos = target.position.x + offset.x;
        //}


        //if (transform.position.y + offset.y <= 21 && transform.position.y + offset.y >= 4)
        //{
        //    _ypos = target.position.y + offset.y;
        //}


        _pos = new Vector3(_xpos, _ypos, offset.z);
        transform.position = _pos;
    }

}
