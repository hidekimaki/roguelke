using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[CreateAssetMenu(fileName = "Card", menuName = "")]
public class Card : ScriptableObject
{
    public string Title;

    public RawImage image;

    public List<Material> recipe;

    public int cardType; // 0-Pure damage 1-Magical 2-Critical
    public CharactersAtributtes atributes;
}
