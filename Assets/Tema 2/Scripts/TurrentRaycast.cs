using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurrentRaycast : MonoBehaviour
{
    [SerializeField] private float distanceRay = 30f;
    [SerializeField] private LayerMask maskToDetect;//puede almacenar mas de un valor
    void Start()
    {//no me combiene crear un rayo aquí, ya que solo se dibujaría una sola vez

    }

    // Update is called once per frame
    void Update()
    {   //Ray
        Ray ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * distanceRay, Color.green);
        //Raycast
        //if (Physics.Raycast(ray))
        //    Debug.DrawRay(ray.origin, ray.direction * distanceRay, Color.cyan);
        //RaycastHit
        //RaycastHit hit;
        //if (Physics.Raycast(ray, out hit))
        //{//devuelve un booleano y algo adicional, información del impacto
        //    Debug.Log("Distancia: " + hit.distance);
        //    Debug.Log("Punto de impacto: " + hit.point);
        //    hit.transform.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
        //}
        //if (Physics.Raycast(ray, out hit, distanceRay))
        //{ 
        //    hit.transform.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;
        //}
        //if (Physics.Raycast(ray, out hit, distanceRay, maskToDetect))
        //{
        //    hit.transform.gameObject.GetComponent<MeshRenderer>().material.color = Color.yellow;
        //}
        //if (Physics.Raycast(ray, out hit, distanceRay, maskToDetect, QueryTriggerInteraction.Ignore))
        //{
        //    hit.transform.gameObject.GetComponent<MeshRenderer>().material.color = Color.black;
        //}
        RaycastHit[] hits;
        hits = Physics.RaycastAll(ray, distanceRay, maskToDetect);
        Debug.Log(hits.Length);
        for(int i = 0; i < hits.Length; i++)
        {
            Debug.Log(hits[i].transform.name);
            hits[i].transform.gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
    }
}