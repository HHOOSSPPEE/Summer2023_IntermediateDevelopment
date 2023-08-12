using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class textChanger : MonoBehaviour
{
    public TMP_Text number;
    private float numberS = 0f;
    public HPManager HPManager;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        numberS = HPManager.healthpoint;
        number.text = numberS.ToString();
    }
}
