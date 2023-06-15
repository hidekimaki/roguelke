using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[CreateAssetMenu(fileName = "Character", menuName = "")]
public class Cosplay : Character
{
    public string CosplayName;
    public RawImage image;
    public int[] cardTypeSlots = new int[5];
    public Card[] CardSlot;


    public void CalculateCharacterAttributes()
    {
        foreach (var item in CardSlot)
        {
            atributes.AddSecondary(item.atributes);
        }

    }
}
