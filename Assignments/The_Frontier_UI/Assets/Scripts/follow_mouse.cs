using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow_mouse : MonoBehaviour
{

    void Update()
    {
        Vector2 cursorpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(cursorpos.x, cursorpos.y);
    }
}
