using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleFly : MonoBehaviour
{
    private Rigidbody2D RB;
    private Vector3 angleNum;
    public float speed;
    private bool act = false;
    private float _ypos;

    void Start()
    {
        _ypos = transform.position.y;
        RB = GetComponent<Rigidbody2D>();
        //Vector3 mouseDir = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        //angleNum = mouseDir;
    }

    void Update()
    {
        Vector3 mouseDir = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        if (mouseDir[1]>= 0)
        {
            //Debug.Log(mouseDir[0]);
            angleNum = mouseDir;
        }
        //Debug.Log(mouseDir);
        if (act == false && Input.GetMouseButtonDown(0))
        {
            RB.velocity = (angleNum * speed);
            //RB.AddForce(Vector3(mouseDir, 0), ForceMode2D.Impulse);
            RB.WakeUp();
            RB.gravityScale = 0.5f;
            act = true;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            _ypos += 0.05f;
            transform.position = new Vector3(transform.position.x, _ypos, transform.position.z);
        }
    }
}
