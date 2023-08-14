using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class HPManager : MonoBehaviour
{
    public int healthpoint = 0;
    public string end;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (healthpoint > 100)
        {
            SceneManager.LoadScene(end);
        }
    }
}
