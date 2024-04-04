using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Variable estática para rastrear el total de monedas recolectadas en todo el juego
    public static int totalCoins = 0;

    void OnTriggerEnter(Collider other)
    {
        // Si el jugador entra en contacto con una moneda, aumenta el total de monedas y destruye la moneda
        if (other.CompareTag("Player"))
        {
            totalCoins++;//coins=coins+1
            Debug.Log(totalCoins);
            Destroy(gameObject);
        }
    }
}