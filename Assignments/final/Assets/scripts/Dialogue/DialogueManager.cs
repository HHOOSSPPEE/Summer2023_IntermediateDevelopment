using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Ink.Runtime;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using System.Linq;

public class DialogueManager : MonoBehaviour
{

    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private TextMeshProUGUI dialogueText;
    [Header("Choices UI")]
    [SerializeField] private GameObject[] choices;
    private TextMeshProUGUI[] choicesText;

    public Story currentStory;
    public bool dialogueIsPlaying { get; private set; }

    private static DialogueManager instance;

    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogWarning("Found more than 1 DM in the scene!!");
        }
        instance = this;
    }

    public static DialogueManager GetInstance()
    {
        return instance;
    }

    private void Start()
    {
        dialogueIsPlaying = false;
        dialoguePanel.SetActive(false);

        //get choices text
        choicesText = new TextMeshProUGUI[choices.Length];
        int index = 0;
        foreach(GameObject choice in choices)
        {
            choicesText[index] = choice.GetComponentInChildren<TextMeshProUGUI>();
            index++;
        }
    }

    private void Update()
    {
        if (!dialogueIsPlaying)
        {
            return;
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                ContinueStory();
            }
        }
    }

    public void EnterDialogueMode(TextAsset inkJSON)
    {
        currentStory = new Story(inkJSON.text);
        dialogueIsPlaying = true;
        dialoguePanel.SetActive(true);

        Debug.Log(currentStory.globalTags.Count);
        if (currentStory.globalTags.Contains("uses_attr "))
        {
            //Debug.Log(GameCtrl.GetInstance().strength);
            currentStory.variablesState["strength"] = GameCtrl.GetInstance().strength;
            currentStory.variablesState["charm"] = GameCtrl.GetInstance().charm;
            Debug.Log("MEGA!");
            currentStory.variablesState["psych"] = GameCtrl.GetInstance().psych;
        }

        ContinueStory();

    }

    private void ExitDialogueMode()
    {
        dialogueIsPlaying = false;
        dialoguePanel.SetActive(false);
        dialogueText.text = "";

        if (SceneManager.GetActiveScene().name == "Menu")
        {
            SceneManager.LoadScene("Game");
        }
    }

    private void ContinueStory()
    {
        if (currentStory.canContinue)
        {
            //set text for current line of dialogue
            dialogueText.text = currentStory.Continue().ToUpper();
            //display choices
            DisplayChoices();
        }
        else
        {
            ExitDialogueMode();
        }
    }

    private void DisplayChoices()
    {
        List<Choice> currentChoices = currentStory.currentChoices;

        if (currentChoices.Count > choices.Length)
        {
            Debug.LogError("more choices than UI supports. Choices given: " + currentChoices.Count);
        }

        int index = 0;
        //enable choice objects up to the amount of choices available in the ink branch
        foreach (Choice choice in currentChoices)
        {
            choices[index].gameObject.SetActive(true);
            choicesText[index].text = choice.text;
            index++;
        }
        //hide leftover choice objects
        for (int i = index; i < choices.Length; i++)
        {
            choices[i].gameObject.SetActive(false);
        }

        StartCoroutine(SelectFirstChoice());

    }

    private IEnumerator SelectFirstChoice()
    {
        //Event system requries we clear it first
        //then wait at least one frame before setting
        //current selected object
        EventSystem.current.SetSelectedGameObject(null);
        yield return new WaitForEndOfFrame();
        if (choices.Length > 0)
        {
            EventSystem.current.SetSelectedGameObject(choices[0].gameObject);
        }
    }

    public void MakeChoice(int choiceIndex)
    {
        currentStory.ChooseChoiceIndex(choiceIndex);
    }

}
