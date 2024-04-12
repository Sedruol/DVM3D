using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExerciseIEnumerators : MonoBehaviour
{
    public VidaJugador vidaJugador;
    [SerializeField] private int num1;
    [SerializeField] private int num2;
    [SerializeField] private float time = 3f;
    [SerializeField] private int[] nums1;
    [SerializeField] private int[] nums2;//tamaño de 3 numeros
    private void Start()
    {
        //Sumando(num1, num2);
        //StartCoroutine(Suma(num1, num2));
        //Exercise 5
        //Aplica lo mismo con un array
        for (int i = 0; i < nums1.Length; i++)//i=0,1,2
            StartCoroutine(Suma(nums1[i], nums2[i]));
    }
    //Exercise 1
    //una suma normal con ienumerator
    //public void Sumando(int x, int y)
    //{
    //    int num = x + y;
    //    Sumando(x, y);
    //}
    //IEnumerator Suma(int x, int y)
    //{
    //    int resultado = x + y;
    //    Debug.Log(resultado);
    //    yield return null;
    //}
    //--------------------------------------------
    //Exercise 2
    //añadele un tiempo de espera y que sea editable
    //IEnumerator Suma(int x, int y)
    //{//tiempo de espera de creacion de cada enemigo
    //    yield return new WaitForSeconds(time);
    //    int resultado = x + y;
    //    Debug.Log(resultado);
    //    yield return new WaitForSeconds(time);
    //    Debug.Log("espere segundos extras");
    //}
    //Exercise 3
    //añadele recursividad, llamar a la función dentro de esta misma
    //IEnumerator Suma(int x, int y)
    //{
    //    yield return new WaitForSeconds(time);
    //    int resultado = x + y;
    //    Debug.Log(resultado);
    //    StartCoroutine(Suma(x, y));
    //}
    //Exercise 4
    //añadele que solo funcione si el jugador tiene vida
    IEnumerator Suma(int x, int y)
    {
        yield return new WaitForSeconds(time);
        if (vidaJugador.vida <= 0)
        {
            yield break;
        }
        int resultado = x + y;
        Debug.Log(resultado);
        StartCoroutine(Suma(x, y));
    }
}