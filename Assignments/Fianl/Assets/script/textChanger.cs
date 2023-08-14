using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class textChanger : MonoBehaviour
{
    public TMP_Text number;
    private float numberS = 0f;
    public HPManager HPManager;
    public string end;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        numberS = HPManager.healthpoint;
        number.text = numberS.ToString();
        if (HPManager.healthpoint >= 100)
        {
            SceneManager.LoadScene(end);
            Debug.Log("end");
        }
    }
}
