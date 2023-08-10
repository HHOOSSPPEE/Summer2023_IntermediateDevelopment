using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    private Toggle redTog;
    private Toggle blueTog;
    private Toggle yellowTog;
    private List<Toggle> toggles = new List<Toggle>();

    private Toggle justClicked;
    private Toggle furthestClicked;

    public Button arrowMakePotion;
    private Transform bigBottle;
    private Image greenBottle;
    private Image orangeBottle;
    private Image purpleBottle;

    void Start()
    {
        //holding on to child images to switch them to parent when needed
        redTog = gameObject.transform.GetChild(0).GetComponent<Toggle>();
        blueTog = gameObject.transform.GetChild(1).GetComponent<Toggle>();
        yellowTog = gameObject.transform.GetChild(2).GetComponent<Toggle>();
        toggles.Add(redTog); toggles.Add(blueTog); toggles.Add(yellowTog);
        bigBottle = gameObject.transform.GetChild(3).transform;

        orangeBottle = bigBottle.GetChild(0).transform.GetComponent<Image>();
        greenBottle = bigBottle.GetChild(1).transform.GetComponent<Image>();
        purpleBottle = bigBottle.GetChild(2).transform.GetComponent<Image>();
    }

    public void Testing()
    {
        if (furthestClicked != null && justClicked != null)
        {
            //justClicked.onValueChanged.Invoke(true);
            //furthestClicked.onValueChanged.Invoke(true);
            justClicked.isOn = true;
            furthestClicked.isOn = true;
            //justClicked.SetIsOnWithoutNotify(true);
            //furthestClicked.SetIsOnWithoutNotify(true);
        }
    }

    public void Reset()
    { //debugging issue idk
        StartCoroutine(RealReset());
    }

    IEnumerator RealReset()
    { //ensures that only 2 bottles can be clicked and visible at a time, then after use requires 4 seconds before another potion can be made
        Product(justClicked, furthestClicked);
        justClicked.SetIsOnWithoutNotify(false);
        furthestClicked.SetIsOnWithoutNotify(false);
        foreach (Toggle x in toggles) { x.enabled = false; }
        gameObject.GetComponent<Button>().enabled = false;
        yield return new WaitForSeconds(4);
        foreach (Toggle x in toggles) { x.enabled = true; x.isOn = false; }
        furthestClicked = null;
        justClicked = null;
        gameObject.GetComponent<Button>().enabled = true;
    }

    void Product(Toggle justClicked, Toggle furthestClicked)
    {
        //determines if 2 bottles are clicked and if so what color will result
        if (justClicked != null && furthestClicked != null)
        {
            if (justClicked != redTog && furthestClicked != redTog)
                bigBottle.GetComponent<Image>().sprite = greenBottle.sprite;
            if (justClicked != blueTog && furthestClicked != blueTog)
                bigBottle.GetComponent<Image>().sprite = orangeBottle.sprite;
            if (justClicked != yellowTog && furthestClicked != yellowTog)
                bigBottle.GetComponent<Image>().sprite = purpleBottle.sprite;
        }
    }

    //all functions below allow each bottle to set themselves as the most recent or last recent one clicked, so that if a player
    //changes their mind the game knows which to not count

    public void RedChanges()
    {
        if (justClicked!= redTog && furthestClicked != redTog) {

            if (justClicked != null)
            {
                if (furthestClicked != null) { furthestClicked.SetIsOnWithoutNotify(false); }
                furthestClicked = justClicked;
            }
            justClicked = redTog;
            
        }
    }
    public void BlueChanges()
    {
        if (justClicked != blueTog && furthestClicked != blueTog)
        {

            if (justClicked != null)
            {
                if (furthestClicked != null) { furthestClicked.SetIsOnWithoutNotify(false); }
                furthestClicked = justClicked;
            }
            justClicked = blueTog;

        }
    }
    public void YellowChanges()
    {
        if (justClicked != yellowTog && furthestClicked != yellowTog)
        {

            if (justClicked != null)
            {
                if (furthestClicked != null) { furthestClicked.SetIsOnWithoutNotify(false); }
                furthestClicked = justClicked;
            }
            justClicked = yellowTog;

        }
    }
}
