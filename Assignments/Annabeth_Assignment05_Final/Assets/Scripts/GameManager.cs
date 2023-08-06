using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Nick;
    public GameObject Rick;
    //true: Nick; false: Rick
    public bool characterChange;
    // Start is called before the first frame update
    void Start()
    {
        //Controlling Nick
        characterChange = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (characterChange)
            {
                characterChange = false;
            }
            else
            {
                characterChange = true;
            }
            
        }
    }
}
