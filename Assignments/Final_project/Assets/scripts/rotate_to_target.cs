using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate_to_target : MonoBehaviour
{
    public float rotation_speed;
    private Vector2 direction;
    

    // Update is called once per frame
    void Update()
    {
        direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotation_speed * Time.deltaTime);
    }
}
