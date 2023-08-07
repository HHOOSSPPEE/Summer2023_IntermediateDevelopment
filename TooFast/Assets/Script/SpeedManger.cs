using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedManger : MonoBehaviour
{
    public float Speedmult;

    public int Stage = 1;
    [Header("Phase1")]
    public GameObject phase1;
    [Header("Phase2")]
    public GameObject phase2;
    public GameObject phase2_speed;
    [Header("Phase3")]
    public GameObject phase3;
    public GameObject phase3_speed;


    private void Update()
    {
        if (Speedmult > 0.24f && Speedmult < 0.5f)
        {
            Stage = 2;
        }
        else if (Speedmult >= 0.5f)
        {
            Stage = 3;
        }
        else
        {
            Stage = 1;
        }
       

        if (Stage == 1)
        {
            phase1.gameObject.SetActive(true);
            phase2.gameObject.SetActive(false);
            phase3.gameObject.SetActive(false);
            phase2_speed.gameObject.SetActive(false);
        }
        else if (Stage == 2)
        {
            phase1.gameObject.SetActive(false);
            phase2.gameObject.SetActive(true);
            phase3.gameObject.SetActive(false);
            phase3_speed.gameObject.SetActive(false);
            phase2_speed.gameObject.SetActive(true);
        }
        else if (Stage == 3)
        {
            phase1.gameObject.SetActive(false);
            phase2.gameObject.SetActive(false);
            phase3.gameObject.SetActive(true);
            phase2_speed.gameObject.SetActive(false);
            phase3_speed.gameObject.SetActive(true);
        }
    }

    public void SpeedUp()
    {
        if (Stage != 3)
        {
            Speedmult += 0.01f;
        }
        else
        {
            Speedmult += 0.1f;
        }
    }

    public void SpeedDown()
    {
        Speedmult -= 0.005f;
    }
}
