using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        string tag = collision.gameObject.tag;
        switch (tag)
        {
            case "dead":
                GameMan.instance.GameEnd();
                break;
            case "bouncer":
                GameMan.instance.UpdateScore(10, 1);
                break;
            case "point":
                GameMan.instance.UpdateScore(20, 1);
                break;
            case "flipper":
                GameMan.instance.mult=1;
                break;
            default:
                break;
        }
    }
}
