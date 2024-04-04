using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]private string enemyState;
    //private enum EnemyState { Idle, Walk, Attack};
    //private EnemyState enemyState;
    void Start()
    {
        enemyState = "Idle";
        //enemyState = EnemyState.Idle;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            State1();
            //State2();
        }
    }

    private void State1()
    {
        switch (enemyState)
        {
            case "Idle":
                Debug.Log("El jugador está estático");
                break;
            case "Walk":
                Debug.Log("El jugador está caminando");
                break;
            case "Attack":
                Debug.Log("El jugador está atacando");
                break;
        }
    }
    //private void State2()
    //{
    //    switch (enemyState)
    //    {
    //        case EnemyState.Idle:
    //            Debug.Log("El jugador está estático");
    //            break;
    //        case EnemyState.Walk:
    //            Debug.Log("El jugador está caminando");
    //            break;
    //        case EnemyState.Attack:
    //            Debug.Log("El jugador está atacando");
    //            break;
    //    }
    //}
}