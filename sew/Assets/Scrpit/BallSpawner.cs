using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using TMPro;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameManger gameManger;
    public GameObject BallPrefab;
    public float respawnTime = 2.0f;
    public int MoenyCost = 1;

    private void Start()
    {
        StartCoroutine(ballwave());
    }

    private void spawnball()
    { 
        //spawn the ball
        GameObject ball = Instantiate(BallPrefab) as GameObject;
        ball.transform.position = new Vector2(Random.Range(7, -7), 7);
    }

    IEnumerator ballwave()
    {
        while (true)
        {
            //when ball spawn wait 2 second and give player money
            yield return new WaitForSeconds(respawnTime);
            spawnball();
            gameManger.money = gameManger.money + MoenyCost;
        }
    }


}
