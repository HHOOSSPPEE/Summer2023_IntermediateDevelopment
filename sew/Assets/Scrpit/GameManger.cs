using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using UnityEngine.SceneManagement;

public class GameManger : MonoBehaviour
{
    public int money;
    public int mood;
    public string Win;
    public string Lose;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if player have more than $30 they win
        if (money > 30) 
        {
            SceneManager.LoadScene(Win);
        }

        //if player have less than $0 or 0 mood they lose
        if (mood <= 0 || money <= 0) 
        {
            SceneManager.LoadScene(Lose);
        }
    }
}
