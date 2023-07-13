using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowballGrowth : MonoBehaviour
{
    public GameObject snowball;
    private Vector3 increaseAmount, startSize;
    private Vector2 startPosition;
    private CircleCollider2D circleCollider;
    public AudioSource knockSound;


    // Start is called before the first frame update
    void Start()
    {
        startSize = new Vector3(snowball.transform.localScale.x, snowball.transform.localScale.y, snowball.transform.localScale.z);
        increaseAmount = new Vector3(0.002f, 0.002f, 0.000f);
        circleCollider = snowball.GetComponent<CircleCollider2D>();
        startPosition = new Vector2(snowball.transform.position.x, snowball.transform.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.hasChanged)
        {
            snowball.transform.localScale += increaseAmount;
            transform.hasChanged = false;
            //circleCollider.radius = snowball.spriteHalfSize.x;
        }
        if (snowball.transform.position.y <= -10)
        {
            snowball.transform.position = startPosition;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.transform.parent.gameObject.name.Equals("WallsYesGrow"))
        {
            snowball.transform.localScale = startSize;
            transform.hasChanged = false;
            
        }
        else
        {
            knockSound.Play();
        }
        
    }
   

}
