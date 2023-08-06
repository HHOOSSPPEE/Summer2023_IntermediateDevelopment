using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowWayPoints : MonoBehaviour
{
    public GameObject[] Points;
    int currentPoint = 0;
    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = Points[currentPoint].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        //if (Vector3.Distance(this.transform.position, Points[currentPoint].transform.position) < 1)
        //{
        //    currentPoint++;
        //}
        //if (currentPoint >= Points.Length)
        //{
        //    currentPoint = 0;

        //}
        //this.transform.LookAt(Points[currentPoint].transform);
        //this.transform.Translate(0, 0, speed * Time.deltaTime, Space.World);
    }
    private void Move()
    {
        print(Points[currentPoint].transform.position);
        transform.position = Vector3.MoveTowards(transform.position, Points[currentPoint].transform.position, speed * Time.deltaTime);
        if (transform.position == Points[currentPoint].transform.position)
        {
            currentPoint++;
        }
        if (currentPoint >= Points.Length)
        {
            currentPoint = 0;

        }
    }
}
