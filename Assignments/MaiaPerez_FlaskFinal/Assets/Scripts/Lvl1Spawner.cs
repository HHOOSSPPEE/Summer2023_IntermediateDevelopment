using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl1Spawner : MonoBehaviour
{
    public CameraScript camScrip;
    public GameObject Scientist;
    public GameObject Biologist;
    private Vector2 bioPosition = new Vector2(8.43f, 0.707f);
    private Vector2 sciPosition = new Vector2(8.43f, -0.3f);
    private bool checkForWin = false;
    private bool dontStop = true;

    // Update is called once per frame
    void Update()
    {
        //scientist can spawn in all lanes, biologist can only spawn on top lane becuase of downwards movement
        if (Random.value < 0.5f) sciPosition.y = -0.3f;
        else sciPosition.y = bioPosition.y;

        if (camScrip.startSpawner && dontStop)
        {
            StartCoroutine(SpawnTimes());
            dontStop = false;
        }
        if (checkForWin)
        {
            if (GameObject.FindGameObjectsWithTag("Scientist").Length == 0 && GameObject.FindGameObjectsWithTag("Biologist").Length == 0)
            {
                GameObject.Find("NonPerma UI").transform.GetChild(0).gameObject.SetActive(false);
                GameObject.Find("WinUI").transform.GetChild(0).gameObject.SetActive(true);
            }
        }
    }

    IEnumerator SpawnTimes()
    { //spawns more enemies
        yield return new WaitForSeconds(8);
        Instantiate(Scientist, sciPosition, Quaternion.identity);
        yield return new WaitForSeconds(6);
        Instantiate(Biologist, bioPosition, Quaternion.identity);
        yield return new WaitForSeconds(10);
        Instantiate(Scientist, sciPosition, Quaternion.identity);
        yield return new WaitForSeconds(10);
        Instantiate(Scientist, sciPosition, Quaternion.identity);
        yield return new WaitForSeconds(5);
        Instantiate(Biologist, bioPosition, Quaternion.identity);
        yield return new WaitForSeconds(2);
        Instantiate(Scientist, sciPosition, Quaternion.identity);
        yield return new WaitForSeconds(12);
        Instantiate(Scientist, sciPosition, Quaternion.identity);
        yield return new WaitForSeconds(5);
        Instantiate(Biologist, bioPosition, Quaternion.identity);
        yield return new WaitForSeconds(7);
        Instantiate(Scientist, sciPosition, Quaternion.identity);
        yield return new WaitForSeconds(6);
        Instantiate(Scientist, sciPosition, Quaternion.identity);
        checkForWin = true;
    }
}
