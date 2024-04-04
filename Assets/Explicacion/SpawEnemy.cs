using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawEnemy : MonoBehaviour
{
    public GameObject enemy;
    public Transform spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(enemy, spawnPoint.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
