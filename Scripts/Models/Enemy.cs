using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Enemy", menuName = "")]
public class Enemy : Character
{
    public string EnemyName;
    public RawImage image;
    public List<EnemyAction> actionList;

    public EnemyAction decideAction()
    {
        int sum = 0;
        foreach (var item in actionList)
        {
            sum += item.priority;
        }
        EnemyAction[] chance = new EnemyAction[sum];
        int aux = 0;
        foreach (var item in actionList)
        {
            for (int i = 0; i < item.priority; i++)
            {
                chance[aux] = item;
                aux++;
            }
        }
        return chance[Random.Range(1, sum)];
    }

}
