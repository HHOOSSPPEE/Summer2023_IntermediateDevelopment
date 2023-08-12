using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monsterFight : MonoBehaviour
{
    public int playerCorruption = 0;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player_1")
        {
            Debug.Log(playerCorruption);
            playerCorruption += 10;
}
    }
}
