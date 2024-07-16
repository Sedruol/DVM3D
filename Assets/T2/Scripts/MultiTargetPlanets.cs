using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiTargetPlanets : MonoBehaviour
{
    public GameObject firstPlanet;
    private int modelsCount;
    [Header("Ingresa un número entre 0 y 8")]
    public int indexCurrentModel = 0;
    private int newIndexPlanet;
    private GameObject newPlanet;

    void Start()
    {
        modelsCount = transform.childCount;
        indexCurrentModel=firstPlanet.transform.GetSiblingIndex();
        //if (indexCurrentModel < 0) indexCurrentModel = 0;
        //else if (indexCurrentModel > 8) indexCurrentModel = 8;
        transform.GetChild(indexCurrentModel).gameObject.SetActive(true);
    }
    public void ChangePlanet(int indexPosition)
    {
        transform.GetChild(indexCurrentModel).gameObject.SetActive(false);
        newIndexPlanet = indexCurrentModel + indexPosition;
        if (newIndexPlanet < 0)
            newIndexPlanet = modelsCount - 1;
        else if (newIndexPlanet > modelsCount - 1)
            newIndexPlanet = 0;
        newPlanet = transform.GetChild(newIndexPlanet).gameObject;
        newPlanet.SetActive(true);
        indexCurrentModel = newPlanet.transform.GetSiblingIndex();
    }
}