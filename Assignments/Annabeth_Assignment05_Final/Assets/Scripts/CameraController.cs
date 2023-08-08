using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
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


        if ((transform.position.x >= 3.5 && target.position.x <= 3.5) || (transform.position.x <= -10 && target.position.x >= -10) || (transform.position.x <= 3.5 && transform.position.x >= -10))
        {
            _xpos = target.position.x + offset.x;
        }

        if ((transform.position.y <= 4 && target.position.y >= -0.5) || (transform.position.y >= 21 && target.position.y <= 21) || (transform.position.y <= 21 && transform.position.y >= 4))
        {
            _ypos = target.position.y + offset.y;
        }


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
