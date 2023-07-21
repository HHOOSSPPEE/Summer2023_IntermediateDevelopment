using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class textChanger : MonoBehaviour
{
    public TMP_Text number;
    private float numberS = 0f;
    public scoreManager scoreManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        numberS = scoreManager.score;
        number.text = numberS.ToString();
    }
}
