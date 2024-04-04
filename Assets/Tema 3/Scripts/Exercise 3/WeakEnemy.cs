using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeakEnemy : MonoBehaviour
{
    /*void Start()
    {
        GameController.Instance.MegaBombReleased += GotDamage;
    }*/

    private void GotDamage(float damage)
    {
        DestroyAndDieByDeath();
    }

    private void DestroyAndDieByDeath()
    {
        Debug.Log(name + "destruido");
        Destroy(this.gameObject);
    }
    /*private void OnDestroy()
    {
        GameController.Instance.MegaBombReleased -= GotDamage;
    }*/
    private void OnBecameVisible()
    {
        GameController.Instance.MegaBombReleased += GotDamage;
    }
    private void OnBecameInvisible()
    {
        GameController.Instance.MegaBombReleased -= GotDamage;
    }
}