using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Instantiator : MonoBehaviour
{
 
    public GameObject monster;
    public Vector2 location;
    private GameObject playerObj = null;
    public float timeRemaining = 6;
    public Vector2 spawnPosition;
    public int MonsterNumber = 0;
    public int seedNumber = 6;
    public Transform playerTransform;
    public GameObject plant;


    //*
    // Update is called once per frame
    private void Start()
    {
        if (playerObj == null)
        {
            playerObj = GameObject.Find("Player_1");
        }
    }
    void Update()
    {
        Vector2 spawnPosition = Vector2.zero;
        spawnPosition.x = Random.Range(-11, 11);
        spawnPosition.y = Random.Range(-8, 8);


        playerTransform = playerObj.GetComponent<Transform>();

        if (Input.GetKeyDown(KeyCode.Space) && seedNumber > 1)
        {
            Instantiate(plant, playerTransform.position + (transform.forward), Quaternion.identity);
            seedNumber -= 1;
        }

        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else if(timeRemaining <= 0 && MonsterNumber < 6)
        {
            MonsterNumber++;
            Instantiate(monster,spawnPosition, Quaternion.identity);
            timeRemaining = 6;
        }
    }
}
