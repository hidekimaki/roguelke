using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharacterStatusController : MonoBehaviour
{
    public TMP_Text CurrentCharacterName;

    public TMP_Text CurrentCharacterPHYS_ATK;
    public TMP_Text CurrentCharacterPHYS_DEF;
    public TMP_Text CurrentCharacterHEALTH;
    public TMP_Text CurrentCharacterbreakBar;
    public TMP_Text CurrentCharacterMANA;
    public TMP_Text CurrentCharacterultimateChargeRate;
    public TMP_Text CurrentCharacteraggro;


    private void Start()
    {
        UpdatePlayerStatusPanel(0);
    }

    public void UpdatePlayerStatusPanel(int id)
    {
        CurrentCharacterName.text = "Nome:" + PlayerSave.data.party[id].CosplayName;
        CurrentCharacterPHYS_ATK.text = "PHYS_ATK:" + PlayerSave.data.party[id].atributes.PHYS_ATK;
        CurrentCharacterPHYS_DEF.text = "PHYS_DEF:" + PlayerSave.data.party[id].atributes.PHYS_DEF;
        CurrentCharacterHEALTH.text = "HEALTH:" + PlayerSave.data.party[id].atributes.HEALTH;
        CurrentCharacterbreakBar.text = "break bar::" + PlayerSave.data.party[id].atributes.POSTURE;
        CurrentCharacterMANA.text = "mana:" + PlayerSave.data.party[id].atributes.ULTIMATE_POTENCY;
        CurrentCharacterultimateChargeRate.text = "ult charge rate:" + PlayerSave.data.party[id].atributes.ultimateChargeRate;
        CurrentCharacteraggro.text = "aggro:" + PlayerSave.data.party[id].atributes.AGGRO;
    }

}
