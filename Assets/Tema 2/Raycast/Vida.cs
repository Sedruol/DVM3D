using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{
    public float hp = 100;
    public void PierdeVida(float da�o, Vector3 posicionImpacto)
    {
        Debug.Log("La vida del enemigo " + name + " es " + hp);
        Debug.Log("Da�o recibido: " + da�o);
        Debug.Log("Posicion del impacto: " + posicionImpacto);
        hp -= da�o;
        Debug.Log("La vida del enemigo " + name + " tras recibir da�o es " + hp);
    }
}
