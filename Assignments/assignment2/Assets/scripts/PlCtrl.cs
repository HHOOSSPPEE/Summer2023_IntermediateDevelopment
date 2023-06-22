using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlCtrl : MonoBehaviour
{
    private Rigidbody2D myRB;
    private Animator myAnim;
    public SpriteRenderer sprRend;

    [SerializeField]
    private float speed;
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
        myAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        myRB.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * speed;

        myAnim.SetFloat("moveX", myRB.velocity.x);
        myAnim.SetFloat("moveY", myRB.velocity.y);

        float HAxis = Input.GetAxisRaw("Horizontal");

        Debug.Log(HAxis);

        if (HAxis != 0)
        {

        }

        if (HAxis < 0)
        {
            sprRend.flipX = true;
        }
        else if (HAxis > 0)
        {
            sprRend.flipX = false;
        }
    }
}
