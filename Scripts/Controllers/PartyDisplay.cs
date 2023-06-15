using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PartyDisplay : MonoBehaviour
{
    public GameObject[] CharacterDisplayInfo = new GameObject[4];
    public TMP_Text name;

    // Start is called before the first frame update
    void Start()
    {
        UpdateDisplayParty();
    }

    public void UpdateDisplayParty()
    {
        for (int i = 0; i < CharacterDisplayInfo.Length; i++)
        {
            CharacterDisplayInfo[i].GetComponentInChildren<TMP_Text>().text = PlayerSave.data.party[i].CosplayName;
        }
    }


}
