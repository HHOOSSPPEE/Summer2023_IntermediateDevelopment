using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pegRule : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Lava")
        {
            ScoreKeep.Score -= 2;
            Destroy(gameObject);
            
        }
        if (collision.gameObject.tag == "Gold")
        {
            ScoreKeep.Score += 3;
        }
        else
        {
            ScoreKeep.Score += 0;
        }


    }
    

void Update()
    {
      //  print(Score);
    }
}
