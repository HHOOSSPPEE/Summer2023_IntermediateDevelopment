using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public CameraScript camScrip;
    public GameObject Scientist;
    private Vector2 sciPosition = new Vector2(8.43f, 0.707f);
    private bool checkForWin = false;
    private bool dontStop = true;

    // Update is called once per frame
    void Update()
    {
        if (camScrip.startSpawner && dontStop)
        {
            StartCoroutine(SpawnTimes());
            dontStop = false;
        }
        if (checkForWin)
        {
            if (GameObject.FindGameObjectsWithTag("Scientist").Length == 0)
            {
                GameObject.Find("NonPerma UI").transform.GetChild(0).gameObject.SetActive(false);
                GameObject.Find("WinUI").transform.GetChild(0).gameObject.SetActive(true);
            }
        }
    }

    IEnumerator SpawnTimes()
    {
        yield return new WaitForSeconds(9);
        Instantiate(Scientist, sciPosition, Quaternion.identity);
        yield return new WaitForSeconds(6);
        Instantiate(Scientist, sciPosition, Quaternion.identity);
        yield return new WaitForSeconds(4);
        Instantiate(Scientist, sciPosition, Quaternion.identity);
        yield return new WaitForSeconds(4);
        Instantiate(Scientist, sciPosition, Quaternion.identity);
        yield return new WaitForSeconds(7);
        Instantiate(Scientist, sciPosition, Quaternion.identity);
        yield return new WaitForSeconds(4);
        Instantiate(Scientist, sciPosition, Quaternion.identity);
        checkForWin = true;
    }
}
