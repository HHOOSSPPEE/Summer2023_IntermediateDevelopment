using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public bool directionVertical = false;
    public float movementSpeed = 1.5f;
    public Rigidbody2D _rigidbody;
    public Vector2 _movement;
    private float topBound = 3;
    private float leftBound = -12;
    private float rightBound = 17;
    //private float lowerBound = -10;
    // public Animator playerAnimator;
    public Vector2 _previousPosition;

    void Start()
    {
        _previousPosition = _rigidbody.position;        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 p = transform.position;
        if (_rigidbody.position == _previousPosition)
        {
            //idle
            //playerAnimator.SetBool("moving", false);
        }
        else if (p.y > topBound)
        {
            p.y = topBound;
            transform.position = p;

            Debug.Log("top");
        }
        else if (p.y < -topBound)
        {
            p.y = -topBound;
            transform.position = p;
            Debug.Log("bottom");
        }
        else if (p.x < leftBound)
        {
            p.x = leftBound;
            transform.position = p;
            Debug.Log("left");
        }
        else if (p.x > rightBound)
        {
            p.x = rightBound;
            transform.position = p;
            Debug.Log("right");
        }

        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            directionVertical = false;
        }
        else if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            directionVertical = true;
        }

        _movement.x = Input.GetAxis("Horizontal");
        _movement.y = Input.GetAxis("Vertical");

        _previousPosition = _rigidbody.position;
    }

    private void FixedUpdate()
    {
        _rigidbody.MovePosition(_rigidbody.position + _movement * movementSpeed);
    }
}
