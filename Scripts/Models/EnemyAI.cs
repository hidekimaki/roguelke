using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "EnemyAction", menuName = "")]
public class EnemyAction : ScriptableObject
{
    public string ActionName;
    public int actionType; // 0-Damage deal 1-heal 2-grant effect
    public int target; // 0-self 1-random PC 2-random ally
    public int value;
    public int IDStatusEffect;

    public int priority;

}