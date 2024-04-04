using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetButtonDown("Fire2"))//acceder aquí cuando hago click derecho del mouse
        {
            // Daña a todos los enemigos en pantalla DamageEveryone();
            DamageEveryone();
        }
    }
    void DamageEveryone()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("Enemy");
        for (int i = 0; i < objects.Length; i++)
        {
            objects[i].GetComponent<EnemyController>().Damage(10);
        }
    }//100,85,50,65,70
}