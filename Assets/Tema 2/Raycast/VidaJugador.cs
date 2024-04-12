using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaJugador : MonoBehaviour
{
    public float vida = 100f;

    // Update is called once per frame
    void Update()
    {
        if (vida >= 0)
            vida -= Time.deltaTime;
    }
}