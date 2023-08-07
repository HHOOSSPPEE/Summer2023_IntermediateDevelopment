using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerShoot : MonoBehaviour
{
    public SpeedManger SpeedManger;

    public float offsetX = -0.8f;
    public float offsetY = 1f;

    private int wait = 20;
    [Header("Normal bullet")]
    public GameObject Lv_1_SB;
    public GameObject Lv_2_SB;
    public GameObject Lv_3_SB;

    [Header("Spread Bullet")]
    public GameObject LV_1_SP;
    public GameObject LV_2_SP;
    public GameObject LV_3_SP;

    [Header("Misslie")]
    public GameObject Lv_1_MS;
    public GameObject Lv_2_MS;
    public GameObject Lv_3_MS;
    private Rigidbody2D rigidbody2;

    [Header("bullet using")]
    public bool S_Shoot;
    public bool SP_Shoot;
    public bool M_Shoot;


    private void Awake()
    {
        rigidbody2 = GetComponent<Rigidbody2D>();
        SpeedManger = GameObject.FindObjectOfType<SpeedManger>().GetComponent<SpeedManger>();
        S_Shoot = true;
    }
    

    // Update is called once per frame
    void Update()
    {

        
        wait--;

        if (wait < 0 && S_Shoot == true && SpeedManger.Stage == 1)
        {
            Instantiate(Lv_1_SB, new Vector2(rigidbody2.position.x + offsetX, rigidbody2.position.y + offsetY), Quaternion.identity);
            wait = 40;

        }
        if (wait < 0 && S_Shoot == true && SpeedManger.Stage == 2)
        {
            Instantiate(Lv_2_SB, new Vector2(rigidbody2.position.x + offsetX, rigidbody2.position.y + offsetY), Quaternion.identity);
            wait = 40;

        }
        if (wait < 0 && S_Shoot == true && SpeedManger.Stage == 3)
        {
            Instantiate(Lv_3_SB, new Vector2(rigidbody2.position.x + offsetX, rigidbody2.position.y + offsetY), Quaternion.identity);
            wait = 40;

        }



        if (wait < 0 && SP_Shoot == true && SpeedManger.Stage == 1)
        {
            Instantiate(LV_1_SP, new Vector2(rigidbody2.position.x + offsetX, rigidbody2.position.y + offsetY), Quaternion.identity);
            wait = 40;

        }

        if (wait < 0 && SP_Shoot == true && SpeedManger.Stage == 2)
        {
            Instantiate(LV_2_SP, new Vector2(rigidbody2.position.x + offsetX, rigidbody2.position.y + offsetY), Quaternion.identity);
            wait = 35;

        }

        if (wait < 0 && SP_Shoot == true && SpeedManger.Stage ==3)
        {
            Instantiate(LV_3_SP, new Vector2(rigidbody2.position.x + offsetX, rigidbody2.position.y + offsetY), Quaternion.identity);
            wait = 30;

        }

        if (wait < 0 && M_Shoot == true && SpeedManger.Stage == 1)
        {
            Instantiate(Lv_1_MS, new Vector2(rigidbody2.position.x + offsetX, rigidbody2.position.y + offsetY), Quaternion.identity);
            wait = 100;

        }
        if (wait < 0 && M_Shoot == true && SpeedManger.Stage == 2)
        {
            Instantiate(Lv_1_MS, new Vector2(rigidbody2.position.x + offsetX, rigidbody2.position.y + offsetY), Quaternion.identity);
            wait = 50;

        }
        if (wait < 0 && M_Shoot == true && SpeedManger.Stage == 3)
        {
            Instantiate(Lv_1_MS, new Vector2(rigidbody2.position.x + offsetX, rigidbody2.position.y + offsetY), Quaternion.identity);
            wait = 30;

        }
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.tag == "SPowerUp")
    //    { 
    //        S_Shoot = true;
    //        SP_Shoot = false;
    //        M_Shoot = false;
    //        wait = 10;
    //    }

    //    if (collision.gameObject.tag == "SPPowerUp")
    //    {
    //        SP_Shoot = true;
    //        S_Shoot = false;
    //        M_Shoot= false;
    //        wait = 10;
    //    }

    //    if ((collision.gameObject.tag == "MPowerUp"))
    //    { 
    //        M_Shoot = true;
    //        SP_Shoot = false;
    //        S_Shoot= false;
    //        wait = 10;
    //    }
    //}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "SPowerUp")
        {
            S_Shoot = true;
            SP_Shoot = false;
            M_Shoot = false;
            wait = 10;
        }

        if (collision.gameObject.tag == "SPPowerUp")
        {
            SP_Shoot = true;
            S_Shoot = false;
            M_Shoot = false;
            wait = 10;
        }

        if ((collision.gameObject.tag == "MPowerUp"))
        {
            M_Shoot = true;
            SP_Shoot = false;
            S_Shoot = false;
            wait = 10;
        }
    }
}
