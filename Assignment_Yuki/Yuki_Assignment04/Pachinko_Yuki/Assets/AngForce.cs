using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngForce : MonoBehaviour
{
    Vector3 myVector;
    Rigidbody2D  m_Rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        myVector = new Vector3(0f, 0f, 100f);
        m_Rigidbody = GetComponent<Rigidbody2D>();
    // Update is called once per frame
    void Update()
        {
            m_Rigidbody.velocity = myVector;
        }
    }
}
