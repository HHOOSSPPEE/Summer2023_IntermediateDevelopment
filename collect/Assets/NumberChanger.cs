using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberChanger : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text number;
    private float cost = 0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void numberchanger()
    {
        //change the cost 
        cost = cost + 49.99f;
        number.text = cost.ToString() + "$";
    }

}
