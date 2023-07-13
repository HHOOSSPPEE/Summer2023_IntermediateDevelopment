using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
  private float bounceForce;
   [SerializeField] string playerTag;
    // Start is called before the first frame update
    void Start()
    {
        bounceForce = 40f;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == playerTag)
        {
            Rigidbody otherRB = collision.rigidbody;
            otherRB.AddExplosionForce(bounceForce, collision.contacts[0].point, 5);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
