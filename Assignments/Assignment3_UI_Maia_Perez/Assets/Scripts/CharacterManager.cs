using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharacterManager : MonoBehaviour
{
    private TMP_Text playerName;
    // Start is called before the first frame update
    void Start()
    {
        playerName = GameObject.FindGameObjectWithTag("GameController").GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
