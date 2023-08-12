using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMove : MonoBehaviour
{
    public GameObject monster;
    public GameObject Player_1;
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        monster.transform.position = Vector2.MoveTowards(monster.transform.position, Player_1.transform.position, step);
    }
    }

