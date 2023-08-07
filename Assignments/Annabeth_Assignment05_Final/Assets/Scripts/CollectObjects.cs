using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectObjects : MonoBehaviour
{

    public GameObject bubble, cross, marry, boxKey, detect;
    public ActiveObject marryRecordO, boxKeyO, closetO, diningTableO, tableO;

    public GameObject ProgressBar;
    public GameObject Bar;
    public bool colliding;
    private bool collected;

    private bool timeToDisappear;

    public GameManager GM;
    // Start is called before the first frame update
    void Start()
    {
        timeToDisappear = false;
        bubble.SetActive(false);
        boxKey.SetActive(false);
        marry.SetActive(false);
        detect.SetActive(false);
        cross.SetActive(false);
        ProgressBar.SetActive(false);

        marryRecordO = GameObject.Find("MarriageRecord_P").GetComponent<ActiveObject>();
        boxKeyO = GameObject.Find("BoxKey_P").GetComponent<ActiveObject>();
        closetO = GameObject.Find("Closet_P").GetComponent<ActiveObject>();
        diningTableO = GameObject.Find("DiningTable_P").GetComponent<ActiveObject>();
        tableO = GameObject.Find("Table_P").GetComponent<ActiveObject>();

        GM = GameObject.Find("GameManager").GetComponent<GameManager>();

        colliding = false;
        collected = false;

    }
    // Update is called once per frame
    void Update()
    {
        marryRecordO = GameObject.Find("MarriageRecord_P").GetComponent<ActiveObject>();
        boxKeyO = GameObject.Find("BoxKey_P").GetComponent<ActiveObject>();
        closetO = GameObject.Find("Closet_P").GetComponent<ActiveObject>();
        diningTableO = GameObject.Find("DiningTable_P").GetComponent<ActiveObject>();
        tableO = GameObject.Find("Table_P").GetComponent<ActiveObject>();
        Bar = GameObject.Find("barFill");

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
            timeToDisappear = true;
            //colliding = true;
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 7 && collision.gameObject.GetComponent<ActiveObject>().collected == false)
        {
            //colliding = true;
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
                //print(Bar.GetComponent<ProgressBar>().timesUpNext);
                if (collected)
                {
                    Bar.GetComponent<ProgressBar>().timesUpNext = false;
                    Bar.GetComponent<ProgressBar>().energy = 0;
                    ProgressBar.SetActive(false);
                    ////parlor
                    if (collision.gameObject.name == "MarriageRecord_P")
                    {
                        GM.marriageCertificate = true;
                        marryRecordO.collected = true;
                        detect.SetActive(false);
                        marry.SetActive(true);
                    }
                    else if (collision.gameObject.name == "BoxKey_P")
                    {
                        boxKeyO.collected = true;
                        detect.SetActive(false);
                        boxKey.SetActive(true);
                    }
                    else if (collision.gameObject.tag == "Empty")
                    {
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
        }

    }

}