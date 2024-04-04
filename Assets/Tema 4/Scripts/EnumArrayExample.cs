using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Names { Mario, Luigi, Peach, Bowser };
public class EnumArrayExample : MonoBehaviour
{
    // Crear un arreglo de nombres de personajes con tamaño fijo
    [SerializeField] private Names[] characterNames = new Names[3];
    void Start()
    {
        AssignValues();
        PrintData();
        ChangeValue();
    }
    private void AssignValues()
    {
        // Asignar valores a los elementos del arreglo
        characterNames[0] = Names.Mario;
        characterNames[1] = Names.Luigi;
        characterNames[2] = Names.Peach;
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
        characterNames[1] = Names.Bowser;
        foreach (Names name in characterNames)
        {
            Debug.Log("Personaje: " + name);
        }
    }
}