using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreKeep : MonoBehaviour
{
    public static int Score;
    private int extraGold;
    // Start is called before the first frame update
    void Start()
    {
        Score = 10;
        extraGold = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            extraGold += 1;
            ScoreKeep.Score -= 0+ extraGold;
            if (extraGold >= 20)
            {
                extraGold = 20;
            }
        }
        print(Score);
        if (Score < 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

            
        }
    }    

}

