using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokemonEnemy : PokemonObjects 
{
    // Start is called before the first frame update
    /*public void Start()
    {
        //_spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        _spriteRenderer.sprite = pokemon.pokemonSprite[0];
    }*/

    public override void Spawn()
    {
        _spriteRenderer.sprite = pokemon.pokemonSprite[0];
    }

}
