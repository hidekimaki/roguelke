using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{
    public static Data data;

    public List<Character> AllCharacters;

    public List<Card> AllCards;

    private void Awake()
    {
        data = this;
    }


}