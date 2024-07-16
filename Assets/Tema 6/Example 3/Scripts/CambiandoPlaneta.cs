using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiandoPlaneta : MonoBehaviour
{
    private int planetCount; //almacene la cantidad de planetas
    private int indexCurrentPlanet = 0; //almacene el indice del planeta actual
    private int newIndexPlanet; //almacena el indice del nuevo planeta
    private GameObject newPlanet; //almacena el objeto del nuevo planeta
    
    void Start()
    {
        //activamos el hijo del indice del planeta actual
        transform.GetChild(indexCurrentPlanet).gameObject.SetActive(true);
        //planet count tiene el valor de la cantidad de hijos que tiene este objeto (ImageTargetSystemSolar) 
        planetCount = transform.childCount;  
    }
    public void ChangePlanet(int indexPosition)
    {
        //accedemos al hijo en la posicion del planeta actual y lo desactivamos
        transform.GetChild(indexCurrentPlanet).gameObject.SetActive(false);
        //obtenemos el valor del indice del nuevo planeta
        newIndexPlanet = indexCurrentPlanet + indexPosition;
        //si el valor del nuevo indice es menor a cero, tendrá el indice del último planeta
        if (newIndexPlanet < 0)
            newIndexPlanet = planetCount - 1;
        else if (newIndexPlanet > planetCount - 1)//si el valor del nuevo indice es mayor al indice del ultimo planeta
            newIndexPlanet = 0;//tomara el valor de cero
        //el objeto del nuevo planeta tomara el valor del hijo de la posicion del nuevo planeta
        newPlanet = transform.GetChild(newIndexPlanet).gameObject;
        //activamos el objeto del nuevo planeta
        newPlanet.SetActive(true);
        //el indice del planeta actual sera el indice del objeto del nuevo planeta
        indexCurrentPlanet = newPlanet.transform.GetSiblingIndex();
    }
}