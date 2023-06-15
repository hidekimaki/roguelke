using UnityEngine;

[CreateAssetMenu(fileName = "CharactersAtributtes", menuName = "")]
public class CharactersAtributtes : ScriptableObject
{

    public const int STRENGHT = 0;
    public const int VITALITY = 1;
    public const int RESISTANCE = 2;
    public const int KNOWLEGDE = 3;
    public const int WILL = 4;
    public const int FOCUS = 0;
    public const int PRECISION = 1;
    public const int REFLEX = 2;
    public const int PERCEPTION = 3;
    public const int MANA = 4;
    public const int ARCANA = 0;
    public const int FORTUNA = 1;
    public const int EMPATHY = 2;
    public const int CHARISMA = 3;
    public const int DECEPTION = 4;

    public int[] ATB = new int[15];




    // Final Values
    public int PHYS_ATK;
    public int PHYS_DEF;
    public int HEALTH;

    public int POSTURE;
    public int ULTIMATE_POTENCY;

    public int ultimateChargeRate;
    public int AGGRO;
    public int criticalStarDropRate;
    public int criticalStarAbsorbRate;

    public int breakDamage;
    public int criticalDamage;

    public int DebuffResistance;

    public void CalculateCharacterAttributes()
    {
        this.HEALTH = ATB[VITALITY] * 10;
        this.POSTURE = ATB[RESISTANCE] + ATB[REFLEX];

        this.PHYS_ATK = ATB[STRENGHT];
        this.breakDamage = ATB[STRENGHT] + ATB[FOCUS];
        this.ULTIMATE_POTENCY = ATB[MANA] + ATB[EMPATHY];
        this.criticalDamage = ATB[KNOWLEGDE] + ATB[FORTUNA];

        this.PHYS_DEF = ATB[VITALITY] + ATB[RESISTANCE];
        this.DebuffResistance = ATB[WILL] + ATB[RESISTANCE];

        this.ultimateChargeRate = ATB[ARCANA] + ATB[CHARISMA];
        this.criticalStarDropRate = ATB[PERCEPTION] + ATB[DECEPTION];
        this.criticalStarAbsorbRate = ATB[PRECISION] + ATB[FORTUNA];
    }


    public void AddSecondary(CharactersAtributtes add)
    {
        this.PHYS_ATK += add.PHYS_ATK;
        this.PHYS_DEF += add.PHYS_DEF;
        this.HEALTH += add.HEALTH;
        this.POSTURE += add.POSTURE;
        this.ULTIMATE_POTENCY += add.ULTIMATE_POTENCY;
        this.ultimateChargeRate += add.ultimateChargeRate;
        this.AGGRO += add.AGGRO;
        this.criticalStarDropRate += add.criticalStarDropRate;
        this.criticalStarAbsorbRate += add.criticalStarAbsorbRate;
        this.breakDamage += add.breakDamage;
        this.criticalDamage += add.criticalDamage;
        this.DebuffResistance += add.DebuffResistance;
    }


    public CharactersAtributtes(int amount)
    {
        for (int i = 0; i < 15; i++)
        {
            ATB[i] = 0;
        }
        for (int i = 0; i < amount; i++)
        {
            int aux = Random.Range(0, 15);
            if (ATB[aux] < 20)
            {
                ATB[aux] += 1;
            }
        }
    }


}