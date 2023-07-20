using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public int playerHealth;
    public bool canTakeDamage = true;


    //public Rigidbody2D _rigidbody;
    //public Vector2 _movement;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Player").transform.position.y < -10)
        {
            //Time.timeScale = 0;
            SceneManager.LoadScene("End");
        }
    }


}
