using UnityEngine;
using UnitySampleAssets.CrossPlatformInput;

namespace CompleteProject
{
    public class PlayerShooting : MonoBehaviour
    {
        public int damagePerShot = 20;                  // Daño que hace cada bala.
        public float timeBetweenBullets = 0.15f;        // Tiempo entre cada disparo.
        public float range = 100f;                      // La distancia a la que puede disparar el arma.


        float timer;                                    // Un cronometro para determinar cuando disparar.
                                                        // Una variable Ray desde el extremo del arma hacia adelante.
                                                        // Una variable Raycast para obtener información sobre lo que fue golpeado.
        int shootableMask;                              // Un layer mask para que el raycast solo colisione con objetos del layer shootable.
        ParticleSystem gunParticles;                    // Referencia al sistema de particulas.
                                                         // Referencia al line renderer.
        AudioSource gunAudio;                           // Referencia al audio source.
        Light gunLight;                                 // Referencia al componente de luz.
        public Light faceLight;							// Duh
        float effectsDisplayTime = 0.2f;                // La proporción del tiempo entre balas durante el cual se mostrarán los efectos.


        void Awake ()
        {
            // Crea un layer mask para el layer Shootable.
            shootableMask = LayerMask.GetMask ("Shootable");

            // Configura las referencias.
            gunParticles = GetComponent<ParticleSystem> ();
            gunAudio = GetComponent<AudioSource> ();
            gunLight = GetComponent<Light> ();
                                                     //referencia del line renderer
			//faceLight = GetComponentInChildren<Light> ();
        }


        void Update ()
        {
            // La variable timer va incrementando su valor conforme avanza el tiempo.
            timer += Time.deltaTime;

            // Si se está presionando el botón izquierdo del mouse y el timer es mayor al tiempo de espera entre cada disparo...
            if (Input.GetButton ("Fire1") && timer >= timeBetweenBullets && Time.timeScale != 0)
            {
                // ... Dispara
                Shoot ();
            }
            // Si el timer ha excedido la proporción de tiempo entre balas durante el cual los efectos deben mostrarse...
            if (timer >= timeBetweenBullets * effectsDisplayTime)
            {
                // ... Desactiva los efectos
                DisableEffects ();
            }
        }


        public void DisableEffects ()
        {// Desactiva el line renderer y las luces.
                                                          //Desactiva el line renderer.
            faceLight.enabled = false;
            gunLight.enabled = false;
        }


        void Shoot ()
        {
            // Reinicia el timer.
            timer = 0f;

            // Reproduce el audioclip de disparo.
            gunAudio.Play ();

            // Activa las luces.
            gunLight.enabled = true;
			faceLight.enabled = true;

            // Detenemos las particulas para volver a activarlas.
            gunParticles.Stop ();
            gunParticles.Play ();

            // Habilite el line renderer y establezca su primera posición para que sea el final del arma.
            
            

            // Configure el rayo de modo que comience en el extremo del arma y apunte hacia adelante desde el cañón.
            
            

            // Realiza el raycast contra objetos del juego en el layer shootable y si golpea algo...
            // if {
            
            
                //Crearemos una variable de tipo EnemyHealth y le asignaremos el componente EnemyHealth del objeto con el que colisionó el rayo.
                
                // Si el componente EnemyHealth existe... if{
                
                
                    // ... el enemigo sufrirá daño.
                    //(La variable de tipo EnemyHealth).TakeDamage(daño, posicion del impacto/colisión);
                    
                
                // }
                // Establezca la segunda posición del line renderer en el punto donde impactó el raycast.
                
            
            // }
            // Si el raycast no impactó con nada en el layer shootable...
            // else{
            
            
                // ... establezca la segunda posición del line renderer en la máxima extensión del alcance del arma.
                
            
            //}
        }
    }
}