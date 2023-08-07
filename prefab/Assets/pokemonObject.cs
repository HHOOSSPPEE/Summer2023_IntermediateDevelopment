using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public abstract class pokemonObject : MonoBehaviour
{
    public temp pokemon;
    public SpriteRenderer spriteRenderer;
    public TMP_Text indexText;
    // Start is called before the first frame update
    void Start()
    {
        //spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        //spriteRenderer.sprite = pokemon.Sprite;
        indexText = GetComponent<TMP_Text>();
        indexText.text = pokemon.pokeindex.ToString();
    }

    public abstract void spawn();
}
