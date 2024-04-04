using UnityEngine;

public class CameraRaycast : MonoBehaviour
{
    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;//le asignamos la c�mara principal de mainCamera
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))//presionar el bot�n izquierdo del mouse
        {
            RaycastHit hit;
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);//Crea un rayo desde la c�mara hacia la posici�n del mouse en la pantalla

            if (Physics.Raycast(ray, out hit))
            {
                hit.transform.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                Debug.DrawRay(ray.origin, ray.direction * 100f, Color.cyan, 1f);
            }
        }
    }
}