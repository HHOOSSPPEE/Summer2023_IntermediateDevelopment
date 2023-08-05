using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomizer : MonoBehaviour
{
    public int randomNumber = 0;
    public int[] numbers = new int[10];
    // Start is called before the first frame update
    void Start()
    {
        randomNumber = Random.Range(0, 9);
        if(randomNumber >= 9)
        {
            randomNumber = 8;
        }
        int lastNumber = 10;

        for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Random.Range(0, 3);

            if (randomNumber > 3)//catch
            {
                randomNumber = 2;
            }

            if(numbers[i] == lastNumber)
            {
                i--;
            }
            else
            {
                lastNumber = numbers[i];
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
