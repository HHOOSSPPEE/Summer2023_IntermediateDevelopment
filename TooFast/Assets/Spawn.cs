using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;

    public GameObject powerUp1;
    public GameObject powerUp2;
    public GameObject powerUp3;

    public float spawnrate = 100;
    private float spawntime;
    public SpeedManger speedManger;

    private void Awake()
    {
        spawntime = spawnrate;
        speedManger = GameObject.FindObjectOfType<SpeedManger>().GetComponent<SpeedManger>();
    }
    // Update is called once per frame
    void Update()
    {
        spawntime -= speedManger.Stage;
        if (spawntime < 0)
        {
            spawnEnemy();
            spawntime = spawnrate;
        }
    }

    private void spawnEnemy()
    {
        int spawn = Random.Range(0, 100);

        if (spawn >= 0 && spawn <= 19)
        {
            Instantiate(enemy1, new Vector2(Random.Range(-8, 8), transform.position.y), transform.rotation);
        }
        else if (spawn >= 20 && spawn <= 39)
        {
            Instantiate(enemy2, new Vector2(Random.Range(-8, 8), transform.position.y), transform.rotation);
        }
        else if (spawn >= 40 && spawn <= 59)
        {
            Instantiate(enemy3, new Vector2(Random.Range(-8, 8), transform.position.y), transform.rotation);
        }
        else if (spawn >= 60 && spawn <= 75)
        {
            Instantiate(enemy4, new Vector2(Random.Range(-8, 8), transform.position.y), transform.rotation);
        }
        else if (spawn >= 76 && spawn <= 85)
        {
            Instantiate(powerUp1, new Vector2(Random.Range(-8, 8), transform.position.y), transform.rotation);
        }
        else if (spawn >= 86 && spawn <= 93)
        {
            Instantiate(powerUp2, new Vector2(Random.Range(-8, 8), transform.position.y), transform.rotation);
        }
        else if (spawn >= 94 && spawn <= 100)
        {
            Instantiate(powerUp3, new Vector2(Random.Range(-8, 8), transform.position.y), transform.rotation);
        }
        else
        {
            Instantiate(enemy1, new Vector2(Random.Range(-8, 8), transform.position.y), transform.rotation);
        }
    }
}
