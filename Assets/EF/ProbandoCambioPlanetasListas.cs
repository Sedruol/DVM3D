using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProbandoCambioPlanetasListas : MonoBehaviour
{
    public List<GameObject> planetPrefabs;
    public Transform SolarSystem;
    [Header("Values Between 0 and 8")]
    public int firstModel;
    private int modelsCount;
    private int indexCurrentModel;
    private int newIndexPlanet;
    private GameObject newPlanet;

    private void Awake()
    {
        GameObject planetCreated;
        for(int i = 0; i < planetPrefabs.Count; i++)
        {
            planetCreated = Instantiate(planetPrefabs[i], SolarSystem.position + new Vector3(0f, 0.06f, 0f), Quaternion.identity, SolarSystem);
            planetCreated.SetActive(false);
            planetCreated.transform.eulerAngles = new Vector3(90f, 0f, 0f);
        }
    }

    void Start()
    {
        modelsCount = transform.childCount;
        indexCurrentModel = firstModel;
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
