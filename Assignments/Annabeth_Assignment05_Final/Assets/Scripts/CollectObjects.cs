using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectObjects : MonoBehaviour
{

    public GameObject bubble, cross, marry, boxKey, detect;
    public GameObject twins, closetKey;
    public GameObject couple1, couple2, mom;
    public GameObject saveKey;
    public GameObject dad, news, parent;
    //parlor
    private ActiveObject marryRecordO, boxKeyO, closetO, diningTableO, tableO;
    //bedroom
    private ActiveObject twinsPhotoO, closetKeyO, closetO2, tableO2, bedO;
    //kitchen
    private ActiveObject couplePhotoO1, couplePhotoO2, momO, stoveO, diningTableO2;
    //hall
    private ActiveObject saveKeyO;
    //masterBR
    private ActiveObject dadO, parentO, newsO, bedO2, deskO, photoO, tableO3, alterO;

    public GameObject ProgressBar;
    public GameObject Bar;
    public bool colliding;
    private bool collected;

    private bool timeToDisappear;

    private GameManager GM;
    // Start is called before the first frame update
    void Start()
    {
        timeToDisappear = false;
        bubble.SetActive(false);
        boxKey.SetActive(false);
        marry.SetActive(false);
        detect.SetActive(false);
        cross.SetActive(false);
        closetKey.SetActive(false);
        twins.SetActive(false);
        couple1.SetActive(false);
        couple2.SetActive(false);
        mom.SetActive(false);
        saveKey.SetActive(false);
        dad.SetActive(false);
        parent.SetActive(false);
        news.SetActive(false);


        ProgressBar.SetActive(false);

        //parlor
        marryRecordO = GameObject.Find("MarriageRecord_P").GetComponent<ActiveObject>();
        boxKeyO = GameObject.Find("BoxKey_P").GetComponent<ActiveObject>();
        closetO = GameObject.Find("Closet_P").GetComponent<ActiveObject>();
        diningTableO = GameObject.Find("DiningTable_P").GetComponent<ActiveObject>();
        tableO = GameObject.Find("Table_P").GetComponent<ActiveObject>();
        //bedroom
        twinsPhotoO = GameObject.Find("TwinsPhoto_B").GetComponent<ActiveObject>();
        closetKeyO = GameObject.Find("ClosetKey_B").GetComponent<ActiveObject>();
        closetO2 = GameObject.Find("Closet_B").GetComponent<ActiveObject>();
        tableO2 = GameObject.Find("Table_B").GetComponent<ActiveObject>();
        bedO = GameObject.Find("Bed_B").GetComponent<ActiveObject>();
        //kitchen
        couplePhotoO1 = GameObject.Find("Photo1_K").GetComponent<ActiveObject>();
        couplePhotoO2 = GameObject.Find("Photo2_K").GetComponent<ActiveObject>();
        momO = GameObject.Find("Mom_K").GetComponent<ActiveObject>();
        diningTableO2 = GameObject.Find("DiningTable_K").GetComponent<ActiveObject>();
        stoveO = GameObject.Find("Stove_K").GetComponent<ActiveObject>();
        //hall
        saveKeyO = GameObject.Find("SaveKey_H").GetComponent<ActiveObject>();
        //masterBR
        dadO = GameObject.Find("Dad_M").GetComponent<ActiveObject>();
        parentO = GameObject.Find("Parent_M").GetComponent<ActiveObject>();
        newsO = GameObject.Find("News_M").GetComponent<ActiveObject>();
        bedO2 = GameObject.Find("Bed_M").GetComponent<ActiveObject>();
        deskO = GameObject.Find("Desk_M").GetComponent<ActiveObject>();
        photoO = GameObject.Find("Photo_M").GetComponent<ActiveObject>();
        tableO3 = GameObject.Find("Table_M").GetComponent<ActiveObject>();
        alterO = GameObject.Find("Alter_M").GetComponent<ActiveObject>();

        GM = GameObject.Find("GameManager").GetComponent<GameManager>();

        colliding = false;
        collected = false;

    }
    // Update is called once per frame
    void Update()
    {
        ////parlor
        //marryRecordO = GameObject.Find("MarriageRecord_P").GetComponent<ActiveObject>();
        //boxKeyO = GameObject.Find("BoxKey_P").GetComponent<ActiveObject>();
        //closetO = GameObject.Find("Closet_P").GetComponent<ActiveObject>();
        //diningTableO = GameObject.Find("DiningTable_P").GetComponent<ActiveObject>();
        //tableO = GameObject.Find("Table_P").GetComponent<ActiveObject>();
        //Bar = GameObject.Find("barFill");
        ////bedroom
        //twinsPhotoO = GameObject.Find("TwinsPhoto_B").GetComponent<ActiveObject>();
        //closetKeyO = GameObject.Find("ClosetKey_B").GetComponent<ActiveObject>();
        //closetO2 = GameObject.Find("Closet_B").GetComponent<ActiveObject>();
        //tableO2 = GameObject.Find("Table_B").GetComponent<ActiveObject>();
        //bedO = GameObject.Find("Bed_B").GetComponent<ActiveObject>();

        if (ProgressBar.activeSelf == true)
        {
            //print(Bar.GetComponent<ProgressBar>().timesUpNext);
            if (Bar.GetComponent<ProgressBar>().timesUpNext)
            {
                collected = true;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.layer == 7 && collision.gameObject.GetComponent<ActiveObject>().collected == false)
        {
            colliding = true;
            timeToDisappear = true;
            
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 7 && collision.gameObject.GetComponent<ActiveObject>().collected == false)
        {
            colliding = true;
            if (timeToDisappear)
            {
                bubble.SetActive(true);
                detect.SetActive(true);
            }
            
            if (Input.GetKey(KeyCode.X))
            {
                timeToDisappear = false;
                ProgressBar.SetActive(true);
            }

            if (ProgressBar.activeSelf == true)
            {
                if (collected)
                {
                    Bar.GetComponent<ProgressBar>().timesUpNext = false;
                    Bar.GetComponent<ProgressBar>().energy = 0;
                    ProgressBar.SetActive(false);
                    //parlor
                    if (collision.gameObject.name == "MarriageRecord_P")
                    {
                        GM.marriageCertificate = true;
                        marryRecordO.collected = true;
                        detect.SetActive(false);
                        marry.SetActive(true);
                    }
                    else if (collision.gameObject.name == "BoxKey_P")
                    {
                        GM.keyBox = true;
                        boxKeyO.collected = true;
                        detect.SetActive(false);
                        boxKey.SetActive(true);
                    }
                    //bedroom
                    else if (collision.gameObject.name == "TwinsPhoto_B")
                    {
                        GM.twinsPhoto = true;
                        twinsPhotoO.collected = true;
                        detect.SetActive(false);
                        twins.SetActive(true);
                    }
                    else if (collision.gameObject.name == "ClosetKey_B")
                    {
                        GM.keyCloset = true;
                        closetKeyO.collected = true;
                        detect.SetActive(false);
                        closetKey.SetActive(true);
                    }
                    //kitchen
                    else if(collision.gameObject.name == "Photo1_K")
                    {
                        GM.couplePhoto1 = true;
                        couplePhotoO1.collected = true;
                        detect.SetActive(false);
                        couple1.SetActive(true);
                    }
                    else if (collision.gameObject.name == "Photo2_K")
                    {
                        GM.couplePhoto2 = true;
                        couplePhotoO2.collected = true;
                        detect.SetActive(false);
                        couple2.SetActive(true);
                    }
                    else if (collision.gameObject.name == "Mom_K")
                    {
                        if (GM.keyBox)
                        {
                            GM.photo1 = true;
                            momO.collected = true;
                            detect.SetActive(false);
                            mom.SetActive(true);
                        }
                        else
                        {
                            boxKey.SetActive(true);

                        }
                    }
                    //hall
                    else if (collision.gameObject.name == "SaveKey_H")
                    {
                        GM.keySave = true;
                        saveKeyO.collected = true;
                        detect.SetActive(false);
                        saveKey.SetActive(true);
                    }
                    //masterBR
                    else if (collision.gameObject.name == "News_M")
                    {
                        GM.newsPaper = true;
                        newsO.collected = true;
                        detect.SetActive(false);
                        news.SetActive(true);
                    }
                    else if (collision.gameObject.name == "Dad_M")
                    {
                        if (GM.keyCloset)
                        {
                            GM.photo2 = true;
                            dadO.collected = true;
                            detect.SetActive(false);
                            dad.SetActive(true);
                        }
                        else
                        {
                            closetKey.SetActive(true);

                        }
                    }
                    else if (collision.gameObject.name == "Parent_M")
                    {
                        if (GM.keySave)
                        {
                            GM.photo3 = true;
                            parentO.collected = true;
                            detect.SetActive(false);
                            parent.SetActive(true);
                        }
                        else
                        {
                            saveKey.SetActive(true);

                        }
                    }

                    else if (collision.gameObject.tag == "Empty")
                    {
                        //parlor
                        if (collision.gameObject.name == "Closet_P")
                        {
                            closetO.collected = true;
                        }
                        else if (collision.gameObject.name == "DiningTable_P")
                        {
                            diningTableO.collected = true;
                        }
                        else if (collision.gameObject.name == "Table_P")
                        {
                            tableO.collected = true;
                        }
                        //bedroom
                        else if (collision.gameObject.name == "Table_B")
                        {
                            tableO2.collected = true;
                        }else if (collision.gameObject.name == "Closet_B")
                        {
                            closetO2.collected = true;
                        }else if(collision.gameObject.name == "Bed_B")
                        {
                            bedO.collected = true;
                        }
                        //kitchen
                        else if (collision.gameObject.name == "Stove_K")
                        {
                            stoveO.collected = true;
                        }
                        else if (collision.gameObject.name == "DiningTable_K")
                        {
                            diningTableO2.collected = true;
                        }
                        //masterBR
                        else if (collision.gameObject.name == "Bed_M")
                        {
                            bedO2.collected = true;
                        }
                        else if (collision.gameObject.name == "Desk_M")
                        {
                            deskO.collected = true;
                        }
                        else if (collision.gameObject.name == "Photo_M")
                        {
                            photoO.collected = true;
                        }
                        else if (collision.gameObject.name == "Table_M")
                        {
                            tableO3.collected = true;
                        }
                        else if (collision.gameObject.name == "Alter_M")
                        {
                            alterO.collected = true;
                        }
                        detect.SetActive(false);
                        cross.SetActive(true);
                    }
 
                }
            }
        }

    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 7)
        {
            collected = false;
            colliding = false;

            if (ProgressBar.activeSelf == true)
            {
                Bar.GetComponent<ProgressBar>().timesUpNext = false;
                Bar.GetComponent<ProgressBar>().energy = 0;
                ProgressBar.SetActive(false);
            }
            
            StartCoroutine(Disappear(collision.gameObject));
        }

    }

    IEnumerator Disappear(GameObject collision)
    {
        yield return new WaitForSeconds(0.2f);
        if (collision.gameObject.layer == 7)
        {
            bubble.SetActive(false);
            detect.SetActive(false);
            //parlor
            if (collision.gameObject.name == "MarriageRecord_P")
            {
                marry.SetActive(false);
            }
            if (collision.gameObject.name == "BoxKey_P")
            {
                boxKey.SetActive(false);
            }
            if (collision.gameObject.tag == "Empty")
            {
                cross.SetActive(false);
            }
            if (collision.gameObject.name == "TwinsPhoto_B")
            {
                twins.SetActive(false);
            }
            if (collision.gameObject.name == "ClosetKey_B")
            {
                closetKey.SetActive(false);
            }
            if (collision.gameObject.name == "Photo1_K")
            {
                couple1.SetActive(false);
            }
            if (collision.gameObject.name == "Photo2_K")
            {
                couple2.SetActive(false);
            }
            if (collision.gameObject.name == "Mom_K")
            {
                if (GM.keyBox)
                {
                    mom.SetActive(false);
                }
                else
                {
                    boxKey.SetActive(false);
                }

            }
            if (collision.gameObject.name == "SaveKey_H")
            {
                saveKey.SetActive(false);
            }
            if (collision.gameObject.name == "Dad_M")
            {
                if (GM.keyCloset)
                {
                    dad.SetActive(false);
                }
                else
                {
                    closetKey.SetActive(false);
                }

            }
            if (collision.gameObject.name == "Parent_M")
            {
                if (GM.keySave)
                {
                    parent.SetActive(false);
                }
                else
                {
                    saveKey.SetActive(false);
                }

            }
            if (collision.gameObject.name == "News_M")
            {
                news.SetActive(false);
            }
        }



    }

}