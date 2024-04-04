using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public delegate void DelegateScore(int newScore);
    public event DelegateScore EventScore;
    //public static event DelegateScore EventScore;//usando static
    private int score;//score=0
    private int randomValue;

    public void AddScore(int num)//Addscore(num=1)
    {
        score += num;//score=0+4, score =4, score =4+1=5
        //EventScore?.Invoke(score);
        if (EventScore != null) EventScore(score);
    }
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))//cuando haga click izquierdo en el mouse
        {
            randomValue = Random.Range(0, 5);//0,1,2,3,4
            Debug.Log("random: " + randomValue);
            AddScore(randomValue);
        }
    }
}