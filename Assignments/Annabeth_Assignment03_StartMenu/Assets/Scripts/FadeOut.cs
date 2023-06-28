using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOut : MonoBehaviour
{
    //credit to 
    //Alexander Zotov (2017, Aug 9, 2017). How to fade out or fade in a game object with coroutine in Unity game | Unity 2D tutorial.
    //YouTube.https://youtu.be/oNz4I0RfsEg

    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    IEnumerator ImageFadeOut()
    {
        for(float f = 1f; f >= -0.05f; f -= 0.05f)
        {
            Color color = spriteRenderer.material.color;
            color.a = f;
            spriteRenderer.material.color = color;
            yield return new WaitForSeconds(0.05f);
        }
    }

    public void StartFading()
    {
        StartCoroutine("ImageFadeOut");
    }
}
