using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class GameCtrl : MonoBehaviour
{

    public static GameCtrl instance;

    public int strength;
    public int charm;
    public int psych;

    [Header("intro elements")]
    public GameObject bg;
    public GameObject mutant;
    public TextAsset IntroScript;

    private string attr = "";
    
    void Awake()
    {

        charm = 0;
        psych = 0;
        strength = 0;

        bg.SetActive(false);
        mutant.SetActive(false);

        DontDestroyOnLoad(this);

        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public static GameCtrl GetInstance()
    {
        return instance;
    }

    public void ChooseCharacter(int chara)
    {
        switch (chara)
        {
            case 1:
                strength++;
                attr = "strong";
                break;
            case 2:
                charm++;
                attr = "charming";
                break;
            case 3:
                psych++;
                attr = "in tune";
                break;
        }

        StartCoroutine(StartIntro());
    }

    private IEnumerator StartIntro()
    {

        GameObject.Find("Characters").SetActive(false);

        yield return new WaitForSeconds(.6f);

        bg.SetActive(true);

        yield return new WaitForSeconds(.8f);
        mutant.SetActive(true);
        yield return new WaitForSeconds(.3f);
        DialogueManager dialCtr = DialogueManager.GetInstance();
        dialCtr.EnterDialogueMode(IntroScript);
        dialCtr.currentStory.variablesState["attribute"] = attr;

    }


}

