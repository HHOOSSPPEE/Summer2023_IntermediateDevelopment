using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sDanc : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(reet());
    }

    IEnumerator reet()
    {
        yield return new WaitForSeconds(5);
        switch (gameObject.name)
        {
            case "foog_0":
                musicMan.musManInstance.snBase.volume = 1;
                musicMan.musManInstance.snFrogger.volume = 0;
                break;
            case "caaat_0":
                musicMan.musManInstance.snBase.volume = 1;
                musicMan.musManInstance.snCatter.volume = 0;
                break;
            case "paaaanda_0":
                musicMan.musManInstance.snBase.volume = 1;
                musicMan.musManInstance.snPander.volume = 0;
                break;
        }
        SceneManager.LoadScene("Menu");
    }
}
