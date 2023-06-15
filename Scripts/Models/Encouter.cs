using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Enemy", menuName = "")]
public class Encounter : ScriptableObject
{
    public List<Enemy> enemies;
}
