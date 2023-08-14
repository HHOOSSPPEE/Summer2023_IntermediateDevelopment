using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class MonsterMove : MonoBehaviour
{
    public GameObject monster;
    public GameObject Player_1;
    private GameObject playerObj = null;
    public float speed = 1f;
    public Vector2 target;
    public Transform playerTransform;
    // Start is called before the first frame update
    void Start()
    {
          if (playerObj == null)
        {
            playerObj = GameObject.Find("Player_1");
        }
    }

    // Update is called once per frame
    void Update()
    {
        playerTransform = playerObj.GetComponent<Transform>();
        transform.position = Vector2.MoveTowards(transform.position, playerTransform.position, speed * Time.deltaTime);
    }
    }

