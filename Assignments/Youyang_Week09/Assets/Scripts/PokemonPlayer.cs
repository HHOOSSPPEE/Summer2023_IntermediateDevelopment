using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokemonPlayer : PokemonObjects
{
    /*public void Start()
    {
        //_spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        _spriteRenderer.sprite = pokemon.pokemonSprite[1];
    }*/

    public override void Spawn()
    {
        _spriteRenderer.sprite = pokemon.pokemonSprite[1];
    }
}
