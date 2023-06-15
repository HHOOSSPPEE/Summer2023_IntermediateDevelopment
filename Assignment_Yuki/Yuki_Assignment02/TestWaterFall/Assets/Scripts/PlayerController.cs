using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float _movementSpeed = 1.5f;
    public Rigidbody2D _rigidbody;
    public Vector2 _movement;

    public Animator playerAnimator;
    public Vector2 _previousPosition;

  // Start is called before the first frame update
  void Start()
    {
        _previousPosition = _rigidbody.position;
    }

    // Update is called once per frame
    void Update()
    {
        _movement.x = Input.GetAxisRaw("Horizontal");
        _movement.y = Input.GetAxisRaw("Vertical");


        if (_rigidbody.position == _previousPosition) {
            //idle
            playerAnimator.SetBool("moving", false);
        }
      
        else if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) //move up

            { 
                Debug.Log("Up");
                playerAnimator.SetInteger("direction", 1); //1=up
            }
            else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)) //move down
            {
                Debug.Log("Down");
                playerAnimator.SetInteger("direction", 3); //1=up
            }
            else if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) //move left
            {
                Debug.Log("Left");
                playerAnimator.SetInteger("direction", 2); //1=up
            }
            else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) //move right
            {
                Debug.Log("Rigt");
                playerAnimator.SetInteger("direction", 4); //1=up
            }

        
       
        _previousPosition = _rigidbody.position;

    
    }

    private void FixedUpdate()
    {
        _rigidbody.MovePosition(_rigidbody.position + _movement* _movementSpeed);
        Debug.Log(_movement);
    }
}

/* if (Input.GetKeyDown(KeyCode.W)||Input.GetKeyDown(KeyCode.UpArrow)) //move up
 {
     Debug.Log("Up");
 }
 else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)) //move down
 {
     Debug.Log("Down");
 }
 else if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) //move left
 {
     Debug.Log("Left");
 }
 else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) //move right
 {
     Debug.Log("Rigt");
 }
*/