using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    [Header("mult")]
    public SpeedManger SpeedManger;

    [Header("Bullet offset")]
    public float offsetX = 0f;
    public float offsetY = 0f;

    [Header("Enemy HP")]
    public int HP = 20;
    public int lifetime = 1000;
    public AudioSource sound;
    public AudioSource explosion;

    [Header("Explosion")]
    public GameObject explosionEffect;
    public shake shakeffect;

    [Header("Behaver")]
    public bool follower = false;
    public Transform target;
    public bool chaser;
    //public bool burst = false;

    [Header("Enemy moving")]
    public float moveX = 0;
    public float moveY = 0;

    [Header("using bullet")]
    public GameObject Enemy_Bullet;
    public float ShootTime = 100;
    private float Cool;
    public GameObject follow_bullet;
    

    [Header("RB and else")]
    public Rigidbody2D Rigidbody;
    public scoresaver scoresaver;

    [Header("SW")]
    public SecondWind secondWind;
    private void Awake()
    {
        sound = GetComponent<AudioSource>();
        Cool = ShootTime;
        Rigidbody = GetComponent<Rigidbody2D>();
        SpeedManger = GameObject.FindObjectOfType<SpeedManger>().GetComponent<SpeedManger>();
        explosion = GameObject.FindGameObjectWithTag("SoundM").GetComponent<AudioSource>();
        shakeffect = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<shake>();
        scoresaver = GameObject.FindGameObjectWithTag("Score").GetComponent <scoresaver>();
        secondWind = GameObject.FindGameObjectWithTag("SW").GetComponent<SecondWind>();
    }

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        lifetime--;

        //charge enemy move
        if (SpeedManger.Stage == 1 && follower == false)
        {
            Rigidbody.position = new Vector2((Rigidbody.position.x + moveX), (Rigidbody.position.y + moveY));
        }
        if (SpeedManger.Stage == 2 && follower == false)
        {
            Rigidbody.position = new Vector2((Rigidbody.position.x + (moveX * 2)), (Rigidbody.position.y + (moveY * 2)));
        }
        if (SpeedManger.Stage == 3 && follower == false)
        {
            Rigidbody.position = new Vector2((Rigidbody.position.x + (moveX* 3)), (Rigidbody.position.y + (moveY * 3)));
        }

        //follower enemy move
        if (SpeedManger.Stage == 1 && follower == true)
        {
            Vector2 direction = (Vector2)target.position - Rigidbody.position;
            direction.Normalize();
            float rotateAmount = Vector3.Cross(direction, -transform.up).z;
            Rigidbody.angularVelocity = -rotateAmount * 200f;
            Rigidbody.velocity = -transform.up * 2f;
        }
        else if (SpeedManger.Stage == 2 && follower == true)
        {
            Vector2 direction = (Vector2)target.position - Rigidbody.position;
            direction.Normalize();
            float rotateAmount = Vector3.Cross(direction, - transform.up).z;
            Rigidbody.angularVelocity = -rotateAmount * 400f;
            Rigidbody.velocity = - transform.up * 6;
        }
        else if (SpeedManger.Stage == 3 && follower == true)
        {
            Vector2 direction = (Vector2)target.position - Rigidbody.position;
            direction.Normalize();
            float rotateAmount = Vector3.Cross(direction,- transform.up).z;
            Rigidbody.angularVelocity = -rotateAmount * 600f;
            Rigidbody.velocity = -transform.up * 10f;
        }


        //shoot countdown
        Cool -= 1 + (SpeedManger.Speedmult * 3);
        
        //shoot
        if (Cool <= 0 && !follower && !chaser)
        {
            Instantiate(Enemy_Bullet, new Vector2(Rigidbody.position.x + offsetX, Rigidbody.position.y + offsetY), Quaternion.identity);
            Cool = ShootTime;
        }else if (Cool <= 0 && follower && !chaser)
        {
            Instantiate(follow_bullet,  transform.position , Quaternion.identity);
            Cool = ShootTime;
        }

        //HP stuff
        if (HP <= 0)
        {
            explosion.Play();
            Instantiate(explosionEffect, transform.position, transform.rotation);
            shakeffect.start = true;
            SpeedManger.SpeedUp();
            scoresaver.score += 100 * (SpeedManger.Speedmult + 1f);
            secondWind.Still();
            Destroy(gameObject);

        }

        
        if (lifetime <= 0 && !follower)
        {
            SpeedManger.SpeedDown();
            Destroy(gameObject);
        }
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        //what will happen after player hit
        if (collision.gameObject.tag == "Bullet")
        {
            
                sound.Play();
            
            HP--;
        }
        if (collision.gameObject.tag == "Missile")
        {
            
                sound.Play();
            
            HP -= 5;
        }

        if (collision.gameObject.tag == "LifeEnder")
        {
            lifetime = 0;
        }
    }
}
