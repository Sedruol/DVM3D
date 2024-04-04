using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnemyType { EnemyMelee, EnemyRange, EnemyFlying }
public class EnumListExample : MonoBehaviour
{
    [SerializeField] List<EnemyType> enemyTypes = new List<EnemyType>();
    private void Start()
    {
        AddEnemys();
    }
    private void AddEnemys()
    {
        enemyTypes.Add(EnemyType.EnemyMelee);
        enemyTypes.Add(EnemyType.EnemyFlying);
        enemyTypes.Add(EnemyType.EnemyMelee);
        enemyTypes.Add(EnemyType.EnemyRange);
        enemyTypes.Add(EnemyType.EnemyFlying);
        enemyTypes.Add(EnemyType.EnemyRange);
        RemoveEnemys();
    }
    private void PrintDataEnums()
    {
        Debug.Log("--------------");
        for (int i = 0; i < enemyTypes.Count; i++)
        {
            Debug.Log(i + ", " + enemyTypes[i]);
        }
    }
    private void RemoveEnemys()
    {
        PrintDataEnums();
        enemyTypes.Remove(enemyTypes[3]);
        PrintDataEnums();
    }
}
