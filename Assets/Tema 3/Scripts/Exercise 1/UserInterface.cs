using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UserInterface : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textScore;
    [SerializeField] private Score ScriptScore;
    //private Score GOscore;//GameObject.FindWithTag()
    //private void Start()
    //{
    //    GOscore = GameObject.FindWithTag("GameController").transform.GetComponent<Score>();
    //}
    private void OnEnable()
    {
        ScriptScore.EventScore += UpdateScore;
        //GOscore.EventScore += UpdateScore;//GameObject.FindWithTag()
        //Score.EventScore += UpdateScore;//usando static
    }
    private void OnDisable()
    {
        ScriptScore.EventScore -= UpdateScore;
        //GOscore.EventScore += UpdateScore;//GameObject.FindWithTag()
        //Score.EventScore -= UpdateScore;//usando static
    }
    private void UpdateScore(int newScore)//newScore=4, 5
    {
        textScore.text = "Score: " + newScore;
    }
}