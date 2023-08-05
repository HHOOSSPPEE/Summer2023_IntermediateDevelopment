using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Pokemon", menuName = "ScriptableObjects/Pokemon", order = 1)]
public class Pokemon : ScriptableObject
{
    public string pokemonName;
    public int pokedex;
    //public Sprite pokemonSprite;

    public Sprite[] pokemonSprite = new Sprite[8]; 
    public int[] baseStats = new int[6];
}
