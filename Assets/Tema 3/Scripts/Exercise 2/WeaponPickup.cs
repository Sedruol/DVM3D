using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum WeaponName { Pistol, SniperRifle, Shotgun };

public class WeaponPickup : MonoBehaviour
{
    public delegate void WeaponPickupEventHandler(WeaponName weaponName);
    public static event WeaponPickupEventHandler OnWeaponPickedUp;

    [SerializeField] WeaponName weaponName;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Aquí ocurre la lógica para recoger el arma...

            // Disparar el evento para informar a otros sistemas sobre el cambio de arma.
            OnWeaponPickedUp?.Invoke(weaponName);
        }
    }
}
