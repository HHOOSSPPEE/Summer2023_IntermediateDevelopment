using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl2Spawner : MonoBehaviour
{
    public CameraScript camScrip;
    public GameObject Scientist;
    public GameObject Biologist;
    public GameObject Physicist;
    private Vector2 bioPosition = new Vector2(8.43f, 0.707f);
    private Vector2 sciPosition = new Vector2(8.43f, -0.3f);
    private Vector2 physPosition = new Vector2(8.43f, 1.69f);
    private bool checkForWin = false;
    private bool dontStop = true;
    private float number;

    void Update()
    {
        number = Random.value;
        // same thing but 3 lanes
        if (number < 0.33)
        {
            sciPosition.y = 0.707f;
            physPosition.y = 0.707f;
            bioPosition.y = 0.707f;
        }
        else if (number > 0.33 && number < 0.66)
        {
            sciPosition.y = -0.3f;
            physPosition.y = -0.3f;
        }
        else
        {
            sciPosition.y = 1.69f;
            physPosition.y = 1.69f;
            bioPosition.y = 1.69f;
        }

        if (camScrip.startSpawner && dontStop)
        {
            StartCoroutine(SpawnTimes());
            dontStop = false;
        }
        if (checkForWin)
        {
            if (GameObject.FindGameObjectsWithTag("Scientist").Length == 0 && GameObject.FindGameObjectsWithTag("Biologist").Length == 0 && GameObject.FindGameObjectsWithTag("Physicist").Length == 0) 
            {
                GameObject.Find("NonPerma UI").transform.GetChild(0).gameObject.SetActive(false);
                GameObject.Find("WinUI").transform.GetChild(0).gameObject.SetActive(true);
            }
        }
    }

    IEnumerator SpawnTimes()
    { // there was probably a better way to do this
        yield return new WaitForSeconds(8);
        Instantiate(Scientist, sciPosition, Quaternion.identity);
        yield return new WaitForSeconds(6);
        Instantiate(Biologist, bioPosition, Quaternion.identity);
        yield return new WaitForSeconds(4);
        Instantiate(Scientist, sciPosition, Quaternion.identity);
        yield return new WaitForSeconds(10);
        Instantiate(Physicist, physPosition, Quaternion.identity);
        yield return new WaitForSeconds(2);
        Instantiate(Scientist, sciPosition, Quaternion.identity);
        yield return new WaitForSeconds(4);
        Instantiate(Biologist, bioPosition, Quaternion.identity);
        yield return new WaitForSeconds(10);
        Instantiate(Scientist, sciPosition, Quaternion.identity);
        yield return new WaitForSeconds(3);
        Instantiate(Physicist, physPosition, Quaternion.identity);
        yield return new WaitForSeconds(6);
        Instantiate(Scientist, sciPosition, Quaternion.identity);
        yield return new WaitForSeconds(1);
        Instantiate(Scientist, sciPosition, Quaternion.identity);
        yield return new WaitForSeconds(8);
        Instantiate(Biologist, bioPosition, Quaternion.identity);
        yield return new WaitForSeconds(5);
        Instantiate(Scientist, sciPosition, Quaternion.identity);
        yield return new WaitForSeconds(4);
        Instantiate(Physicist, physPosition, Quaternion.identity);
        yield return new WaitForSeconds(8);
        Instantiate(Scientist, sciPosition, Quaternion.identity);
        yield return new WaitForSeconds(3);
        Instantiate(Physicist, physPosition, Quaternion.identity);
        yield return new WaitForSeconds(5);
        Instantiate(Scientist, sciPosition, Quaternion.identity);
        checkForWin = true;
    }
}
