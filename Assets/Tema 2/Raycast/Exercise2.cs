using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise2 : MonoBehaviour
{
    [SerializeField] private float distanceRay;
    [SerializeField] private Transform mira;
    [SerializeField] private LayerMask maskToDetect;
    [SerializeField] private float damage = 25f;
    [SerializeField] private LineRenderer line;
    private RaycastHit hit;
    private Ray ray;
    void Update()
    {
        ray = new Ray(mira.position, mira.forward);
        Debug.DrawRay(ray.origin, ray.direction * distanceRay, Color.green);
        //Exercise 1
        //Un raycast que detecte en todo momento cuando choque con un objeto, deben poder
        //modificar el tamaño del rayo
        //if (Physics.Raycast(ray.origin, ray.direction, out hit, distanceRay))
        //{
        //    Debug.Log("Objeto golpeado: " + hit.transform.name);
        //}
        //else
        //{
        //    Debug.Log("No se golpeó ningún objeto.");
        //}
        //Otra opción
        //if (Physics.Raycast(ray, out hit, distanceRay))
        //{
        //    Debug.Log("Objeto golpeado: " + hit.transform.name);
        //}
        //else
        //{
        //    Debug.Log("No se golpeó ningún objeto.");
        //}
        //==================================================================
        //Exercise 2
        //El raycast solo debe activarse cuando tocas un objeto con layer Shootable
        //if (Physics.Raycast(ray, out hit, distanceRay, maskToDetect))
        //{
        //    Debug.Log("Objeto golpeado: " + hit.transform.name);
        //}
        //else
        //{
        //    Debug.Log("No se golpeó ningún objeto.");
        //}
        //==================================================================
        //Exercise 3
        //El raycast solo debe activarse presionas el botón izquierdo del mouse una vez
        //if (Input.GetButtonDown("Fire1"))
        //{
        //    if (Physics.Raycast(ray, out hit, distanceRay, maskToDetect))
        //    {
        //        Debug.Log("Objeto golpeado: " + hit.transform.name);
        //    }
        //    else
        //    {
        //        Debug.Log("No se golpeó ningún objeto.");
        //    }
        //}
        //==================================================================
        //Exercise 4
        //El raycast solo debe activarse presionas el botón izquierdo del mouse
        //puedes mantener el botón presionado
        //if (Input.GetButton("Fire1"))
        //{
        //    if (Physics.Raycast(ray, out hit, distanceRay, maskToDetect))
        //    {
        //        Debug.Log("Objeto golpeado: " + hit.transform.name);
        //    }
        //    else
        //    {
        //        Debug.Log("No se golpeó ningún objeto.");
        //    }
        //}
        //Exercise 5
        //Accede a un script del objeto que chocó con el rayo
        //if (Input.GetButtonDown("Fire1"))
        //{
        //    if (Physics.Raycast(ray, out hit, distanceRay, maskToDetect))
        //    {
        //        Vida vida = hit.collider.GetComponent<Vida>();
        //        if (vida != null)
        //        {
        //            Debug.Log("Objeto golpeado: " + hit.transform.name);
        //            vida.PierdeVida(damage, hit.point);
        //        }
        //    }
        //    else
        //    {
        //        Debug.Log("No se golpeó ningún objeto.");
        //    }
        //}
        //Exercise 6
        //Conectemos el Raycast con LineRenderer
        if (Input.GetButtonDown("Fire1"))
        {
            line.enabled = true;
            line.SetPosition(0, mira.position);
            if (Physics.Raycast(ray, out hit, distanceRay, maskToDetect))
            {
                Vida vida = hit.collider.GetComponent<Vida>();
                if (vida != null)
                {
                    Debug.Log("Objeto golpeado: " + hit.transform.name);
                    vida.PierdeVida(damage, hit.point);
                }
                line.SetPosition(1, hit.point);
            }
            else
            {
                line.SetPosition(1, ray.origin + ray.direction * distanceRay);
                Debug.Log("No se golpeó ningún objeto.");
            }
        }
    }
}