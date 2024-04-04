using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CompleteProject
{
    public class EnemySpawner : MonoBehaviour
    {
        //---------
        //Variables
        //---------
        public PlayerHealth playerHealth;       // Referencia al Script PlayerHealth
        public GameObject[] enemys;             // Los prefabs de los enemigos que se usarán en el spawn
        public float[] spawnTimes;              // Los tiempos que habrá entre cada spawn de cada enemigo
        public Transform[] spawnPoints;         // Los transforms de los puntos de spawn de cada enemigo

        //-----
        //Start
        //-----
        void Start()
        {
            for (int i = 0; i < enemys.Length; i++)
                StartCoroutine(Spawn(enemys[i], spawnTimes[i], spawnPoints[i]));
        }
        //-----------
        //Ienumerator
        //-----------
        IEnumerator Spawn(GameObject enemy, float spawnTime, Transform spawnPoint)
        {
            yield return new WaitForSeconds(spawnTime);
            // ¿El jugador ya no tiene vida?
            if (playerHealth.currentHealth <= 0f)
            {
                // Salimos de la función
                yield break;
            }
            Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
            StartCoroutine(Spawn(enemy, spawnTime, spawnPoint));
        }
    }
}