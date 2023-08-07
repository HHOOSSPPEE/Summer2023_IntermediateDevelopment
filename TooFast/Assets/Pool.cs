using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pool : MonoBehaviour
{
    public GameObject poolingObject;
    public int poolCount;

    public Queue<GameObject> poolQueue = new Queue<GameObject>(); 

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < poolCount; i++)
        {
            GameObject newCircle = Instantiate(poolingObject, Vector3.zero, Quaternion.identity, gameObject.transform);
            
            poolQueue.Enqueue(newCircle);
        }
    }

    // Update is called once per frame
    void Update()
    {
        GameObject activeBullet = poolQueue.Dequeue();
        activeBullet.SetActive(true);
    }

    

    public void RequeueEnemy(GameObject newBullet)
    { 
        poolQueue.Enqueue(newBullet);
        newBullet.SetActive(false);
        newBullet.transform.position = gameObject.transform.position;
    }
}
