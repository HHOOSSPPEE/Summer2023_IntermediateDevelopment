using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Diagnostics.Contracts;

public class TextChanger : MonoBehaviour
{
    public TMP_Text title;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeText(string newWord)
    {
        int x = 6;
        newWord = x.ToString();
        title.text = newWord;
    }
}
