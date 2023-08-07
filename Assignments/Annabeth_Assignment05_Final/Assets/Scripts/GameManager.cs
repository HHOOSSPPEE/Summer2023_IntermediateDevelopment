using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Nick;
    public GameObject Rick;

    public GameObject Invent;
    //true: Nick; false: Rick
    public bool characterChange;

    public bool marriageCertificate;
    public bool newsPaper;
    public bool twinsPhoto;
    public bool couplePhoto1;
    public bool couplePhoto2;
    public bool photo1;
    public bool photo2;
    public bool photo3;

    // Start is called before the first frame update
    void Start()
    {
        Invent.SetActive(false);
        //Controlling Nick
        characterChange = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (characterChange)
            {
                characterChange = false;
            }
            else
            {
                characterChange = true;
            }
            
        }
    }
}
