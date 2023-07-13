using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color_changer : MonoBehaviour
{
    SpriteRenderer sprite_renderer;
    public Material material;
    public Color[] colors;
    private int currentColorIndex = 0;
    private int targetColorIndex = 1;
    private float targetPoint;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        sprite_renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Transition();
    }

    void Transition()
    {
        targetPoint += Time.deltaTime/time;
        sprite_renderer.color = Color.Lerp(colors[currentColorIndex], colors[targetColorIndex], targetPoint);
        if (targetPoint >=1f)
        {
            targetPoint= 0f;
            currentColorIndex = targetColorIndex;
            targetColorIndex++;
            if(targetColorIndex == colors.Length)
            {
                targetColorIndex = 0;
            }
        }
    }
}
