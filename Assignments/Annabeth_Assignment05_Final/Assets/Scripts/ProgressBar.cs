using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.GraphicsBuffer;

public class ProgressBar : MonoBehaviour
{
    //method from Alexander Zotov on Youtube
    Image Bar;
    public GameObject target;
    public float maxEnergy = 5f;
    public float energy;
    public bool timesUpNext;
    public GameManager GM;
    void Start()
    {
        timesUpNext= false;
        Bar = GetComponent<Image>();
        energy = 0;
    }

    void Update()
    {
        if (GM.characterChange)
        {
            target = GameObject.Find("Nick");
        }
        else
        {
            target = GameObject.Find("Rick");
        }
        //if (target.GetComponent<CollectObjects>().colliding)
        //{
            if (energy < maxEnergy)
            {
                energy += Time.deltaTime;
                Bar.fillAmount = energy / maxEnergy;
            }
            else
            {
                timesUpNext = true;
            }
        //}

    }
}
