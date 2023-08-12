using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletRemove : MonoBehaviour
{
    public int lifetime = 30;

    // Update is called once per frame
    void Update()
    {
        //remove bullet when timerun out
        lifetime--;
        if (lifetime <= 0)
        {
            Destroy(gameObject);
        }
    }
}
