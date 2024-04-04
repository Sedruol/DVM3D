using UnityEngine;
using System;

public enum PlayerStates { Move, Attack, Die};

public class Player : MonoBehaviour
{
    [SerializeField] private PlayerStates playerStates;
    private int randomValue;

    private void ChangeState1(PlayerStates state)
    {
        playerStates = state;
        switch (playerStates)
        {
            case PlayerStates.Move:
                Debug.Log("El jugador se está moviendo");
                break;
            case PlayerStates.Attack:
                Debug.Log("El jugador está atacando");
                break;
            case PlayerStates.Die:
                Debug.Log("El jugador está muriendo");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            randomValue = UnityEngine.Random.Range(0, Enum.GetValues(typeof(PlayerStates)).Length);
            ChangeState1((PlayerStates)randomValue);
            //playerStates = ChangeState2();
            //ReadPlayerState();
        }
    }
    /*private PlayerStates ChangeState2()
    {
        return (PlayerStates)UnityEngine.Random.Range(0, Enum.GetValues(typeof(PlayerStates)).Length);
    }*/

    /*private void ReadPlayerState()
    {
        switch (playerStates)
        {
            case PlayerStates.Move:
                Debug.Log("El jugador se está moviendo");
                break;
            case PlayerStates.Attack:
                Debug.Log("El jugador está atacando");
                break;
            case PlayerStates.Die:
                Debug.Log("El jugador está muriendo");
                break;
        }
    }*/
}