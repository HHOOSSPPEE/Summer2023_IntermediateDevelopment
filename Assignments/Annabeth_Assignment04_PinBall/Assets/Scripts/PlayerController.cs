using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D RB;
    private Vector3 angleNum;
    public float speed;
    public bool act = false;
    private float _ypos;
    public NewLevel NL;
    private int score;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timeLeft;
    private AudioSource coin;
    private float timeSec;

    void Start()
    {
        _ypos = transform.position.y;
        RB = GetComponent<Rigidbody2D>();
        coin = GetComponent<AudioSource>();
        score = 0;
        timeSec = 15f;
    }

    void Update()
    {
        scoreText.text = "Score: " + score;

        if(timeSec >= 0)
        {
            timeSec -= Time.deltaTime;
            timeLeft.text = "Time Left: " + Mathf.RoundToInt(timeSec);
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        
        if (NL.activate == true)
        {
            act = false;
            //NL.activate = false;
        }
        Vector3 mouseDir = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        if (mouseDir[1]>= 0)
        {
            angleNum = mouseDir;
        }
        //Debug.Log(mouseDir);
        if (act == false && Input.GetMouseButtonDown(0))
        {
            RB.velocity = (angleNum * speed);
            RB.WakeUp();
            RB.gravityScale = 0.5f;
            act = true;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            _ypos += 0.05f;
            transform.position = new Vector3(transform.position.x, _ypos, transform.position.z);
        }
    }

    private void OnCollisionEnter2D(Collision2D targetObj)
    {
        if (targetObj.gameObject.tag == "Objects")
        {
            score += 1;
            scoreText.text = "Score: " + score;
            coin.Play();
        }
        else if (targetObj.gameObject.tag == "Monkey")
        {
            score += 100;
            scoreText.text = "Score: " + score;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

}
