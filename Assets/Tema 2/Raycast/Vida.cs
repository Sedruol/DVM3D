using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{
    public float hp = 100;
    public void PierdeVida(float daño, Vector3 posicionImpacto)
    {
        Debug.Log("La vida del enemigo " + name + " es " + hp);
        Debug.Log("Daño recibido: " + daño);
        Debug.Log("Posicion del impacto: " + posicionImpacto);
        hp -= daño;
        Debug.Log("La vida del enemigo " + name + " tras recibir daño es " + hp);
    }
}
