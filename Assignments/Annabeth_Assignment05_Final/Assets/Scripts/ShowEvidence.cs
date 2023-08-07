using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowEvidence : MonoBehaviour
{
    public GameManager GM;

    public Image marriageCertificate;
    public Image newsPaper;
    public Image twinsPhoto;
    public Image couplePhoto1;
    public Image couplePhoto2;
    public Image photo1;
    public Image photo2;
    public Image photo3;
    // Start is called before the first frame update
    void Start()
    {
        marriageCertificate.enabled = false;
        newsPaper.enabled = false;
        twinsPhoto.enabled = false;
        couplePhoto1.enabled = false;
        couplePhoto2.enabled = false;
        photo1.enabled = false;
        photo2.enabled = false;
        photo3.enabled = false;
        GM = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GM.couplePhoto1)
        {
            couplePhoto1.enabled = true;
        }
        if (GM.marriageCertificate)
        {
            marriageCertificate.enabled = true;
        }
    }
}
