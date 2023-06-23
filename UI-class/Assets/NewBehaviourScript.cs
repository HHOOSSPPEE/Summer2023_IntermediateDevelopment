using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    public TMP_Text Title;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Changetext(string newWord)
        {
        int x = 6;
        newWord = x.ToString();
            Title.text = newWord;
        }
}
