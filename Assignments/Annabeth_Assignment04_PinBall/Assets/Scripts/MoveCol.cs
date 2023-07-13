using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoveCol : MonoBehaviour
{
    private float distance;
    private float speed = 0.001f;
    private string dir;
    private bool change;
    // Start is called before the first frame update
    void Start()
    {
        distance = transform.position.x;
        dir = "right";
        change = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (change)
        {
            StartCoroutine(ChangeDirection());
        }
        else
        {
            StartCoroutine(ChangeDirectionLeft());
        }

        if (dir == "right")
        {
            distance -= speed;
        }
        else if (dir == "left")
        {
            distance += speed;
        }
        transform.position = new Vector3(distance, transform.position.y, transform.position.z);
        // Debug.Log(dir);
    }

    IEnumerator ChangeDirection()
    {
        dir = "left";
        yield return new WaitForSeconds(0.5f);
        change = false;
    }

    IEnumerator ChangeDirectionLeft()
    {
        dir = "right";
        yield return new WaitForSeconds(0.5f);

        change = true;
    }
}
