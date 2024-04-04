using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitcher : MonoBehaviour
{
    void Start()
    {
        WeaponPickup.OnWeaponPickedUp += HandleWeaponPickedUp;
    }

    void HandleWeaponPickedUp(WeaponName newWeapon)
    {
        // Aquí ocurre la lógica para cambiar de arma cuando se recoge una nueva.
        Debug.Log("El jugador recogió un(a) " + newWeapon);
        //se podria un switch con los enums y usarlo para decirle el modelo 3D a usar, etc
        switch (newWeapon)
        {
            case WeaponName.Pistol:
                Debug.Log("cambia el arma por el modelo de pistola");
                break;
            case WeaponName.Shotgun:
                Debug.Log("cambiar el arma por el modelo de escopeta");
                break;
        }
    }

    void OnDestroy()
    {
        WeaponPickup.OnWeaponPickedUp -= HandleWeaponPickedUp;
    }
}