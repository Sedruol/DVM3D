using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListExample : MonoBehaviour
{
    // Crear una lista de nombres de personajes
    List<string> enemmyNames = new List<string>();
    private void Start()
    {
        AssignValuesString();
        PrintDataString();
    }
    private void AssignValuesString()
    {
        // Agregar elementos a la lista
        enemmyNames.Add("Mario");
        enemmyNames.Add("Luigi");
        enemmyNames.Add("Peach");
    }
    private void PrintDataString()
    {
        // Acceder a un elemento de la lista
        Debug.Log("El primer personaje es: " + enemmyNames[0]);

        // Obtener la cantidad de elementos en la lista
        Debug.Log("Cantidad de personajes: " + enemmyNames.Count);

        // Iterar sobre la lista
        foreach (string name in enemmyNames)
        {
            Debug.Log("Personaje: " + name);
        }
    }
}