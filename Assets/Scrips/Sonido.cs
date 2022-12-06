using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Sonido : MonoBehaviour
{
    public AudioSource quienEmite;
    public AudioClip sonido;
    public float volumen = 1;
    bool seReprodujoAntes = false;


    private void OnTriggerEnter(Collider other)
    {
        quienEmite.PlayOneShot(sonido, volumen);
    }
}
