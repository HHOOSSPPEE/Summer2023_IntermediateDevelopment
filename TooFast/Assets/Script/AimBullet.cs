using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimBullet : MonoBehaviour
{
    public float mult = 20f;
    public Vector2 movement;
    private float x;
    private Rigidbody2D rb;
    public SpeedManger SpeedManger;
    public Animator animator;

    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        SpeedManger = GameObject.FindObjectOfType<SpeedManger>().GetComponent<SpeedManger>();
        target = GameObject.FindGameObjectWithTag("Player");
        movement = (target.transform.position - transform.position).normalized * (mult + SpeedManger.Speedmult);
        rb.velocity = new Vector2 (movement.x, movement.y);
        Destroy(this.gameObject, 20f);

    }

    
}
