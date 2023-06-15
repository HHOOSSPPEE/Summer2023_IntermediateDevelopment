using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float horizontalMove=.01f;
    public float verticalMove=.01f;
    private float last_deltaX = 0f;
    private float last_deltaY = 0f;
    Animator luluAnim;
    
    // Start is called before the first frame update
    void Start()
    {
        luluAnim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        var v = horizontalMove * Input.GetAxisRaw("Horizontal");
        var h = verticalMove * Input.GetAxisRaw("Vertical");

        transform.Translate(v, h, 0);

        var xSpeed = Input.GetAxisRaw("Horizontal");
        var ySpeed = Input.GetAxisRaw("Vertical");
        if (Input.GetAxisRaw("Horizontal")>0 || Input.GetAxisRaw("Horizontal") < 0||Input.GetAxisRaw("Vertical") < 0|| Input.GetAxisRaw("Vertical") > 0)
        {
            luluAnim.SetBool("isMoving",true);
            Debug.Log("walking");
        }
        else
        {
            luluAnim.SetBool("isMoving",false);
        }

        if (Mathf.Abs(xSpeed)>Mathf.Epsilon || Mathf.Abs(ySpeed) > Mathf.Epsilon)
        {
            last_deltaX = xSpeed;
            last_deltaY = ySpeed;
        }
        luluAnim.SetFloat("deltaX", last_deltaX);
        luluAnim.SetFloat("deltaY", last_deltaY);

        
        
    }
}
