using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayExample : MonoBehaviour
{
    // Crear un arreglo de nombres de personajes con tamaño fijo
    [SerializeField] private string[] characterNames = new string[3];
    void Start()
    {
        AssignValues();
        PrintData();
        ChangeValue();
    }
    private void AssignValues()
    {
        // Asignar valores a los elementos del arreglo
        characterNames[0] = "Mario";
        characterNames[1] = "Luigi";
        characterNames[2] = "Peach";
    }
    private void PrintData()
    {
        // Acceder a un elemento del arreglo
        Debug.Log("El primer personaje es: " + characterNames[0]);

        // Obtener la longitud del arreglo
        Debug.Log("Cantidad de personajes: " + characterNames.Length);

        // Iterar sobre el arreglo
        for (int i = 0; i < characterNames.Length; i++)
        {
            Debug.Log("Personaje: " + characterNames[i]);
        }
    }
    private void ChangeValue()
    {
        Debug.Log("--------------");
        characterNames[1] = "Bowser";
        foreach (string name in characterNames)
        {
            Debug.Log("Personaje: " + name);
        }
    }
}