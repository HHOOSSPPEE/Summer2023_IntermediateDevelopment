using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using UnityEngine.SceneManagement;
using TMPro;

public class award : MonoBehaviour
{
    public GameManger manger;
    public int MoneyGain = 0;
    public int moodGain = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //change the mood and money when collision with ball
        if (collision.gameObject.tag == "ball")
        {
            manger.money = manger.money + MoneyGain;
            manger.mood = manger.mood + moodGain;
            Destroy(collision.gameObject);
            Debug.Log(manger.money);
        }
    }
}
