using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Pokemon", menuName ="SO/Pokemon",order = 1 )]
public class temp : ScriptableObject
{
    public string Name;
    public Sprite Sprite;
    public int pokeindex;

    public int[] baseStates = new int[6];
    public Sprite[] pokemonSprite = new Sprite[2];
}
