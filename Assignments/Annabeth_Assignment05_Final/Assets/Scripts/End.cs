using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour
{
    public bool CC;
    public GameObject EndScreen;
    public GameObject alert;
    public bool DiscoveredByParents;

    public GameObject alarm;
    // Start is called before the first frame update
    void Start()
    {
        CC = GameObject.Find("min").GetComponent<ChangeClock>().bedTime;
        DiscoveredByParents = GameObject.Find("GameManager").GetComponent<SetEnding>().end;
        
    }

    // Update is called once per frame
    void Update()
    {
        CC = GameObject.Find("min").GetComponent<ChangeClock>().bedTime;
        DiscoveredByParents = GameObject.Find("GameManager").GetComponent<SetEnding>().end;

        Debug.Log("parents" + DiscoveredByParents);

        if (CC)
        {
            print("?");
            //StartCoroutine(EndReady());
        }

        if (DiscoveredByParents)
        {
            print("!");
            //StartCoroutine(EndReady());
        }
    }

    //IEnumerator EndReady()
    //{
    //    alert.SetActive(true);
    //    yield return new WaitForSeconds(2);
    //    EndScreen.SetActive(true);
    //    //Time.timeScale = 0;
    //}
}
