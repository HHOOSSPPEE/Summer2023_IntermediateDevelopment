using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    public float movementSpeed = 0.5f;

    public Rigidbody2D _rigidbody;
    public Vector2 _movement;

    //public Animator playerAnimator;
    public Vector2 _previousPosition;

    // Start is called before the first frame update
    void Start()
    {
        _previousPosition = _rigidbody.position;
    }

    // Update is called once per frame
    void Update()
    {
        /*if (_rigidbody.position == _previousPosition)
        {
            playerAnimator.SetBool("moving", false);

        }
        else
        {
            playerAnimator.SetBool("moving", true);
        }*/

        _movement.x = Input.GetAxisRaw("Horizontal");
        _previousPosition = _rigidbody.position;
    }

    private void FixedUpdate()
    {
        _rigidbody.MovePosition(_rigidbody.position + _movement * movementSpeed);
    }
}
