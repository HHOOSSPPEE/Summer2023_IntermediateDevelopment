using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playball : MonoBehaviour
{
    public AudioSource m_AudioSource;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "sew")
        {
            m_AudioSource.Play();
        }
        
    }
}
