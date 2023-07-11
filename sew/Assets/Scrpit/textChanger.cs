using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class textChanger : MonoBehaviour
{
    public TMP_Text number;
    public TMP_Text number2;
    private float mood = 0f;
    private float cost = 0f;
    public GameManger gameManger;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //change the number show on the UI
        cost = gameManger.money;
        number.text = "$" + cost.ToString();
        mood = gameManger.mood;
        number2.text = mood.ToString();
    }
}
