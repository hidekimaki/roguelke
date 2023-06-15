using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// anything related to attributes and values
public abstract class Character : ScriptableObject
{
    public CharactersAtributtes BaseAtributes;
    public CharactersAtributtes atributes;

    public int UltimateType;
    public int UltimateTarget;

    public bool[] CharacterNeutralAction = new bool[3];
    /* 
        0 - Recover HP
        1 - Recover POSTURE
        2 - Recover MANA
    */

    public int PowerAttack()
    {
        return this.atributes.PHYS_ATK + this.atributes.breakDamage;
    }

    public void receivePostureDamage(int damage)
    {
        this.atributes.POSTURE -= damage;
        if (this.atributes.POSTURE > 0) this.atributes.POSTURE = 0;
    }

    public void NeutralAction()
    {
        if (this.CharacterNeutralAction[0] == true)
        {
            this.atributes.HEALTH += this.BaseAtributes.ATB[CharactersAtributtes.VITALITY];
            if (this.atributes.HEALTH > this.BaseAtributes.HEALTH)
            {
                this.atributes.HEALTH = this.BaseAtributes.HEALTH;
            }
        }
        if (this.CharacterNeutralAction[1] == true)
        {
            this.atributes.POSTURE += this.BaseAtributes.ATB[CharactersAtributtes.RESISTANCE];
            if (this.atributes.POSTURE > this.BaseAtributes.POSTURE)
            {
                this.atributes.POSTURE = this.BaseAtributes.POSTURE;
            }
        }
        if (this.CharacterNeutralAction[2] == true)
        {
            this.atributes.ULTIMATE_POTENCY += this.BaseAtributes.ATB[CharactersAtributtes.MANA];
            if (this.atributes.ULTIMATE_POTENCY > this.BaseAtributes.ULTIMATE_POTENCY)
            {
                this.atributes.ULTIMATE_POTENCY = this.BaseAtributes.ULTIMATE_POTENCY;
            }
        }
    }




}
