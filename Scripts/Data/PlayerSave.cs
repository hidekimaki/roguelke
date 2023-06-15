using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSave : MonoBehaviour
{
    public static PlayerSave data;

    public List<Cosplay> party;

    public List<Card> collection;

    public List<Card> RecipesUnlocked;

    public List<Material> inventory;

    public Encounter encounter;

    private void Awake()
    {
        data = this;
    }


}