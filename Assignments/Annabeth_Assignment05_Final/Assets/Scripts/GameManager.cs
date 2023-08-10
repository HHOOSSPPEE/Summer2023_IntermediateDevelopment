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

    public bool marriageCertificate = false;
    public bool newsPaper = false;
    public bool twinsPhoto = false;
    public bool couplePhoto1 = false;
    public bool couplePhoto2 = false;
    public bool photo1 = false;
    public bool photo2 = false;
    public bool photo3 = false;

    public bool keyBox = false;
    public bool keyCloset = false;
    public bool keySave = false;
    public bool finish;

    public static bool reload;
    public GameObject finished;



    // Start is called before the first frame update
    void Start()
    {
        finish = GameObject.Find("Main Camera").GetComponent<CameraController>().tutorialOver;
        Invent.SetActive(false);
        //Controlling Nick
        characterChange = false;

        //reload = false;
       
    }

    // Update is called once per frame
    void Update()
    {
        if (finish)
        {
            finished.SetActive(false);
            reload = true;
        }

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
