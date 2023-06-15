using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

//Control all the interaction of the battle panel
public class BattleController : MonoBehaviour
{
    private const bool debugMode = true;

    public GameObject EnemiesDisplay;

    public GameObject PrefabDisplayEnemy;

    public Encounter encounter;

    public int CurrentEnemyIdTarget;
    public int CurrentCharacterIdTurn;

    public GameObject playerButtonsPanel;
    public GameObject displayTextPanel;

    public void loadEncounter()
    {
        encounter = PlayerSave.data.encounter;
        CurrentCharacterIdTurn = 0;
        printLoadedEncounter();
    }

    public void GenerateEnemies()
    {
        foreach (var item in encounter.enemies)
        {
            GameObject enemy = Instantiate(PrefabDisplayEnemy, EnemiesDisplay.transform);
            enemy.GetComponentInChildren<TMP_Text>().text = item.name;
        }
        CurrentEnemyIdTarget = 0;
    }

    public void BTExecutePlayerActions(int characterAction)
    {

        if (CurrentCharacterIdTurn < 4)
        {
            debugPrint(PlayerSave.data.party[CurrentCharacterIdTurn].name + " Attack on " + PlayerSave.data.encounter.enemies[CurrentEnemyIdTarget].name);

            CurrentCharacterIdTurn++;

            playerButtonsPanel.SetActive(false);
            displayTextPanel.SetActive(true);

            switch (characterAction)
            {
                case 0:
                    QuickAttack();
                    break;
                case 1:
                    TechAttack();
                    break;
                case 2:
                    PowerAttack();
                    break;
                case 3:
                    Defense();
                    break;
            }

        }
        else
        {
            ExecuteEnemyActions();
            ExecuteEndOfTurn();
        }



    }


    public void ExecuteEnemyActions()
    {
        foreach (var item in encounter.enemies)
        {
            item.decideAction();
        }

    }

    public void ExecuteEndOfTurn()
    {
        /*
       -> Execute all DOT effects
       -> Execute all delayed effects (heal, apply new buff, etc)
       -> Remove expiring buffs/ Remove one stack of each buff
       */
    }

    // QUICK ATTACK are focused at generating critical stars and dealing critical hits
    private void QuickAttack()
    {
        debugPrint("Quick Attack");
    }

    // TECH ATTACK are focused at charging MANA (one the MANA value is 100) instead it uses the character ULTIMATE
    private void TechAttack()
    {
        if (PlayerSave.data.party[CurrentCharacterIdTurn].atributes.ULTIMATE_POTENCY == 100)
        {
            debugPrint("Ultimate action");
        }
        else
        {
            debugPrint("Tech Attack");
        }

    }

    // POWER ATTACKS are focused at damaging enemy POSTURE (once POSTURE break enemy receives more damage from all sorces)
    private void PowerAttack()
    {
        debugPrint("PowerAttack");
        int postureDamage = PlayerSave.data.party[CurrentCharacterIdTurn].PowerAttack();
        debugPrint("PowerAttack->postureDamage: " + postureDamage);
        encounter.enemies[CurrentEnemyIdTarget].receivePostureDamage(postureDamage);
    }

    // DEFENSE make the character do a certain neutral action (recover HP/ recover POSTURE/ recover MANA/ APPLY BUFF to SELF)
    private void Defense()
    {
        debugPrint("Defend / Rest");
        PlayerSave.data.party[CurrentCharacterIdTurn].NeutralAction();

    }


    #region print for debug or tests

    private void printLoadedEncounter()
    {
        debugPrint("Character on party:" + PlayerSave.data.party[0].name + PlayerSave.data.party[1].name + PlayerSave.data.party[2].name + PlayerSave.data.party[3].name);

        foreach (var item in PlayerSave.data.encounter.enemies)
        {
            debugPrint("Enemies:" + item.name);
        }

    }

    private void debugPrint(string message)
    {
        if (debugMode) { print(message); }
    }


    #endregion
}
