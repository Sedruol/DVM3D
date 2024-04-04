using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private int enemyHealth = 100;
    public void Damage(int dmg)//dmg=20,25
    {
        enemyHealth -= dmg;//enemyHealth=100-20=80, enemyHealth=80-25=55
        Debug.Log("daño: " + dmg + ", hp: " + enemyHealth);
    }
}