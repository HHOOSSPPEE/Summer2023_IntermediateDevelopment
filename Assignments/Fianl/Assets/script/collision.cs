using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collision : MonoBehaviour {
    
    public int monsterHP = 2;
    public HPManager HPManager;
    public MonsterNum Monster;
    public int Corruption = 10;
    void Start()
    {
         
    //Set the tag of this GameObject to Player
        gameObject.tag = "Monster";
    }


    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
            {
            Debug.Log("playerCorruption");
            HPManager.healthpoint += Corruption;
        }
        if (col.gameObject.tag.Equals("Attack") == true)
        {
            monsterHP -= 1;
        }
       
    }
    private void Update()
    {
        if (monsterHP == 0)
        {
            Destroy(gameObject);
            Monster.MonsterNumber --;

        }

    }
}
