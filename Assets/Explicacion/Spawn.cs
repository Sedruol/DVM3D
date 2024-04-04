using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{    
    public GameObject[] enemys;
    public Transform[] spawnPoints;        
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < enemys.Length; i++)
            Instantiate(enemys[i], spawnPoints[i].position, Quaternion.identity);
        //Instantiate(enemys[0], spawnPoints[0].position, Quaternion.identity);
        //Instantiate(enemys[1], spawnPoints[1].position, Quaternion.identity);
        //Instantiate(enemys[2], spawnPoints[2].position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
