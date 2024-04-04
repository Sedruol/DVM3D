using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    [SerializeField] private string element;
    // Definimos el diccionario para llevar el inventario del jugador (elemento, cantidad)
    private Dictionary<string, int> inventory = new Dictionary<string, int>();

    // Método para agregar un objeto al inventario
    public void AddItem(string itemName)
    {
        // Si el objeto ya está en el inventario, incrementamos la cantidad
        if (inventory.ContainsKey(itemName))
        {
            inventory[itemName]++;
        }
        // Si no está en el inventario, lo agregamos con cantidad 1
        else
        {
            inventory[itemName] = 1;
        }

        Debug.Log("Se agregó 1 " + itemName + " al inventario.");
    }

    // Método para mostrar el inventario
    public void DisplayInventory()
    {
        Debug.Log("Inventario del jugador:");
        foreach (var item in inventory)
        {
            Debug.Log(item.Key + ": " + item.Value);
        }
    }

    // Método para usar un objeto del inventario
    public void UseItem(string itemName)
    {
        if (inventory.ContainsKey(itemName))
        {
            if (inventory[itemName] > 0)
            {
                inventory[itemName]--;
                Debug.Log("Se utilizó 1 " + itemName + " del inventario.");
            }
            else
            {
                Debug.Log("Ya no quedan " + itemName + " en el inventario.");
            }
        }
        else
        {
            Debug.Log("No tienes " + itemName + " en el inventario.");
        }
    }
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            AddItem(element);
            DisplayInventory();
        }
        else if (Input.GetButtonDown("Fire2"))
        {
            UseItem(element);
            DisplayInventory();
        }
    }
}