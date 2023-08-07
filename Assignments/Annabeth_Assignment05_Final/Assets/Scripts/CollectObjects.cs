using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectObjects : MonoBehaviour
{

    public GameObject bubble, cross, marry, boxKey, detect;
    public ActiveObject marryRecordO, boxKeyO, closetO, diningTableO, tableO;

    private bool timeToDisappear;
    // Start is called before the first frame update
    void Start()
    {
        timeToDisappear = false;
        bubble.SetActive(false);
        boxKey.SetActive(false);
        marry.SetActive(false);
        detect.SetActive(false);
        cross.SetActive(false);

        marryRecordO = GameObject.Find("MarriageRecord_P").GetComponent<ActiveObject>();
        boxKeyO = GameObject.Find("BoxKey_P").GetComponent<ActiveObject>();
        closetO = GameObject.Find("Closet_P").GetComponent<ActiveObject>();
        diningTableO = GameObject.Find("DiningTable_P").GetComponent<ActiveObject>();
        tableO = GameObject.Find("Table_P").GetComponent<ActiveObject>();

    }
    // Update is called once per frame
    void Update()
    {
        marryRecordO = GameObject.Find("MarriageRecord_P").GetComponent<ActiveObject>();
        boxKeyO = GameObject.Find("BoxKey_P").GetComponent<ActiveObject>();
        closetO = GameObject.Find("Closet_P").GetComponent<ActiveObject>();
        diningTableO = GameObject.Find("DiningTable_P").GetComponent<ActiveObject>();
        tableO = GameObject.Find("Table_P").GetComponent<ActiveObject>();

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 7 && collision.gameObject.GetComponent<ActiveObject>().collected == false)
        {
            timeToDisappear = true;
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 7 && collision.gameObject.GetComponent<ActiveObject>().collected == false)
        {
            if (timeToDisappear)
            {
                bubble.SetActive(true);
                detect.SetActive(true);
            }
            //parlor
            if (Input.GetKey(KeyCode.X))
            {
                timeToDisappear = false;

                if (collision.gameObject.name == "MarriageRecord_P")
                {
                    marryRecordO.collected = true;
                    detect.SetActive(false);
                    marry.SetActive(true);
                }
                if (collision.gameObject.name == "BoxKey_P")
                {
                    boxKeyO.collected = true;
                    detect.SetActive(false);
                    boxKey.SetActive(true);
                }
                if (collision.gameObject.tag == "Empty")
                {
                    if(collision.gameObject.name == "Closet_P")
                    {
                        closetO.collected = true;
                    }else if(collision.gameObject.name == "DiningTable_P")
                    {
                        diningTableO.collected = true;
                    }else if(collision.gameObject.name == "Table_P")
                    {
                        tableO.collected = true;
                    }

                    detect.SetActive(false);
                    cross.SetActive(true);
                }
            }

        }

    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 7)
        {

            StartCoroutine(Disappear(collision.gameObject));
        }

    }

    IEnumerator Disappear(GameObject collision)
    {
        yield return new WaitForSeconds(1);
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