using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plantGrow : MonoBehaviour
{

    public Instantiator seed;
    
    public Sprite[] spriteArray;
    public float growTime = 30;
    public HPManager HPManager;
    
    public SpriteRenderer spriteRenderer;
   
    
    // Start is called before the first frame update
    void Start()
    {
        gameObject.tag = "Plant";
        growTime = 30;

    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player" && spriteRenderer.sprite == spriteArray[5])
        {
            Debug.Log("playerheal");
            HPManager.healthpoint -= 10;
            seedNumber -= 1;
            Destroy(gameObject);
        }

    }
        void Update()
    {
        //playerCorruption = globalX + playerCorruption;
        



        if (growTime <= 25 && spriteRenderer.sprite == spriteArray[0])
        {
            spriteRenderer.sprite = spriteArray[1];
        }
        else if (growTime <= 20 && spriteRenderer.sprite == spriteArray[1])
        {
            spriteRenderer.sprite = spriteArray[2];
        }
        else if(growTime <= 15 && spriteRenderer.sprite == spriteArray[2])
        {
            spriteRenderer.sprite = spriteArray[3];
        }
        else if (growTime <= 10 && spriteRenderer.sprite == spriteArray[3])
        {
            spriteRenderer.sprite = spriteArray[4];
            
        }
        else if (growTime <= 0 && spriteRenderer.sprite == spriteArray[4])
        {
            spriteRenderer.sprite = spriteArray[5];

        }
        if (growTime > 0)
        {
            growTime -= Time.deltaTime;
        }


    }


}
