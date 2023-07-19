using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameMan : MonoBehaviour
{
    [SerializeField]
    GameObject ball,startButton,highScoreTxt,scoreTxt,restartBtn,quitBtn;

    int score, highScore;

    [SerializeField]
    Rigidbody2D left, right;

    [SerializeField]
    Vector3 startPos;

    public int mult;

    bool canPlay;

    public static GameMan instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        Time.timeScale = 1;
        score = 0;
        mult = 1;
        highScore = PlayerPrefs.HasKey("HighScore") ? PlayerPrefs.GetInt("HighScore") : 0;
        highScoreTxt.GetComponent<TMP_Text>().text = "high\nscore : " + highScore;
        canPlay = false;
    }

    private void Update()
    {
        if (canPlay) return;
        if (Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.LeftArrow))
        {
            left.AddTorque(25f);
        }
        else
        {
            left.AddTorque(-20f);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            right.AddTorque(-25f);
        }
        else
        {
            right.AddTorque(20);
        }
    }

    public void UpdateScore(int point, int multInc)
    {
        mult += multInc;
        score += point * mult;
        scoreTxt.GetComponent<TMP_Text>().text = "score\n : " + score;
    }

    public void GameEnd()
    {
        Time.timeScale = 0;
        highScoreTxt.SetActive(true);
        quitBtn.SetActive(true);
        restartBtn.SetActive(true);
        if (score > highScore)
        {
            PlayerPrefs.SetInt("HighScore", score);
            highScore = score;
        }
        highScoreTxt.GetComponent<TMP_Text>().text = "high\nscore : \n" + highScore;
    }

    public void GameStart()
    {
        highScoreTxt.SetActive(false);
        startButton.SetActive(false);
        scoreTxt.SetActive(true);
        Instantiate(ball, startPos, Quaternion.identity);
    }

    public void GameQuit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }

    public void GameRestart()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
}
