using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private float bombDamage = 25;
    public delegate void MegaBombDelegate(float damage);
    public event MegaBombDelegate MegaBombReleased;
    public static GameController Instance { get; private set; }
    private void Awake()
    {
        if (Instance != null && Instance != this)
            Destroy(this);
        else
            Instance = this;
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire2"))//click derecho del mouse
        {
            // Daña a todos los enemigos en pantalla DamageEveryone();
            MegaBombReleased?.Invoke(bombDamage);
        }
    }
}
