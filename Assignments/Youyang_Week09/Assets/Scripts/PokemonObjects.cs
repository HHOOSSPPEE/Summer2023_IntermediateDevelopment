using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PokemonObjects : MonoBehaviour
{
    public Pokemon pokemon;
    public SpriteRenderer _spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        _spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        //_spriteRenderer.sprite = pokemon.pokemonSprite[0];
        Spawn();
    }

    public abstract void Spawn();
}
