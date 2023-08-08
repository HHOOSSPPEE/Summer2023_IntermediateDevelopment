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

    public Image keyBox;
    public Image keyCloset;
    public Image keySave;
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
        keyBox.enabled = false;
        keyCloset.enabled = false;
        keySave.enabled = false;
        GM = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GM.marriageCertificate)
        {
            marriageCertificate.enabled = true;
        }
        if (GM.twinsPhoto)
        {
            twinsPhoto.enabled = true;
        }
        if (GM.keyBox)
        {
            keyBox.enabled = true;
        }
        if (GM.keyCloset)
        {
            keyCloset.enabled = true;
        }
        if (GM.keySave)
        {
            keySave.enabled = true;
        }
        if (GM.photo1)
        {
            photo1.enabled = true;
        }
        if (GM.photo2)
        {
            photo2.enabled = true;
        }
        if (GM.photo3)
        {
            photo3.enabled = true;
        }
        if (GM.couplePhoto1)
        {
            couplePhoto1.enabled = true;
        }
        if (GM.couplePhoto2)
        {
            couplePhoto2.enabled = true;
        }
        if (GM.newsPaper)
        {
            newsPaper.enabled = true;
        }

    }
}
