using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndManager : MonoBehaviour
{
    public bool CC;
    public GameObject EndScreen;
    public GameObject alert;
    public GameObject alert2;
    public GameObject alert3;
    public GameObject alarm;
    public bool DiscoveredByParents;

    public GameObject Name;
    public GameObject Text;

    public TMP_Text endName;
    public TMP_Text endText;


    public GameManager GM;

    private bool endReached;

    public AudioClip audioSource;
    public AudioClip audioSource2;
    public AudioClip audioChoose;
    public AudioSource audioPlay;
    public float volume = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        CC = GameObject.Find("min").GetComponent<ChangeClock>().bedTime;
        DiscoveredByParents = GameObject.Find("GameManager").GetComponent<SetEnding>().end;
        GM = GameObject.Find("GameManager").GetComponent<GameManager>();
        endReached = false;

        endName = Name.GetComponent<TMP_Text>();
        endText = Text.GetComponent<TMP_Text>();
        audioChoose = audioSource2;

    }

    // Update is called once per frame
    void Update()
    {
        endName = Name.GetComponent<TMP_Text>();
        endText = Text.GetComponent<TMP_Text>();
        CC = GameObject.Find("min").GetComponent<ChangeClock>().bedTime;
        DiscoveredByParents = GameObject.Find("GameManager").GetComponent<SetEnding>().end;

        //Debug.Log("parents" + DiscoveredByParents);

        if (CC)
        {
            if (!endReached)
            {
                alert.SetActive(true);
                StartCoroutine(EndReady());
            }

        }

        if (DiscoveredByParents)
        {
            if (!endReached)
            {
                alert2.SetActive(true);
                StartCoroutine(EndReady());
            }
            //print("!");

        }

        if(GM.marriageCertificate && GM.newsPaper && GM.twinsPhoto && GM.couplePhoto1 && GM.couplePhoto2 && GM.photo1 && GM.photo2 && GM.photo3)
        {
            StartCoroutine(Discover());
            StartCoroutine(EndReady());
            audioChoose = audioSource;
            endName.text = "Cousins";
            endText.text = "We are cousins! Our parents both have twins that perished in the car accident when we were babies, and so the four of us remaining joined together.";

        }else if ((GM.photo1 && GM.photo2 && GM.photo3) == false)
        {
            if (GM.newsPaper)
            {
                
                endName.text = "Addams";
                endText.text = "Something terrible must have happened in this family. Why are they keeping this old newspaper?";
            }else if (GM.marriageCertificate)
            {
                
                endName.text = "Rename";
                endText.text = "Guess mom changed her name, that’s all. What else could it be?";
            }
            else
            {
                endName.text = "Normal";
                endText.text = "Everything's absolutely normal, normal but perfect.";
            }
        }
        else if((GM.photo1 && GM.photo2 && GM.photo3) == true)
        {
            endName.text = "Half done";
            endText.text = "Emmm we sense something fishy….We’ll try again tomorrow!";
        }

    }

    IEnumerator EndReady()
    {
        
        yield return new WaitForSeconds(2);
        audioPlay.PlayOneShot(audioChoose, volume);

        endReached = true;
        alarm.SetActive(false);
        alert.SetActive(false);
        alert2.SetActive(false);
        alert3.SetActive(false);
        EndScreen.SetActive(true);
        audioPlay.Play();
        Time.timeScale = 0;
    }

    IEnumerator Discover()
    {

        yield return new WaitForSeconds(2);
        alert3.SetActive(true);
    }




}
