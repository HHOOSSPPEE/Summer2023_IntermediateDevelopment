using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOut : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    // Start is called before the first frame update

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

    // Update is called once per frame
    void Update()
    {
        
    }
}
