using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerfulEnemy : MonoBehaviour
{
    [SerializeField] private float shield = 100;//100,50,80
    //void Start()
    //{
    //    GameController.Instance.MegaBombReleased += GotDamage;
    //}

    private void GotDamage(float damage)
    {
        shield -= damage;
        if (shield <= 0) DestroyAndDieByDeath();
    }

    private void DestroyAndDieByDeath()
    {
        Debug.Log(name + "destruido");
        Destroy(this.gameObject);
    }
    //private void OnDestroy()
    //{
    //    GameController.Instance.MegaBombReleased -= GotDamage;
    //}
    private void OnBecameVisible()
    {
        GameController.Instance.MegaBombReleased += GotDamage;
    }
    private void OnBecameInvisible()
    {
        GameController.Instance.MegaBombReleased -= GotDamage;
    }
}