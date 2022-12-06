using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador : MonoBehaviour
{
    public CharacterController controller;
    public float velocidad;

    private bool adelante;
    private bool atras;
    private bool izquierda;
    private bool derecha;
    //public Animator anim;
    //public Camera cam;
    //[Header("Animation Smoothing")]
    //[Range(0, 1f)]
    //public float HorizontalAnimSmoothTime = 0.2f;
    //[Range(0, 1f)]
    //public float VerticalAnimTime = 0.2f;
    //[Range(0, 1f)]
    //public float StartAnimTime = 0.3f;
    //[Range(0, 1f)]
    //public float StopAnimTime = 0.15f;

    //void Start()
    //{
    //    anim = this.GetComponent<Animator>();
    //    cam = Camera.main;
    //    controller = this.GetComponent<CharacterController>();
    //}
    private void Update()
    {
        if (adelante == true)
        {
            controller.Move(transform.forward * velocidad * Time.deltaTime);
        }
        if (atras == true)
        {
            controller.Move(-transform.forward * velocidad * Time.deltaTime);
        }
        if (derecha == true)
        {
            controller.Move(transform.right * velocidad * Time.deltaTime);
        }
        if (izquierda == true)
        {
            controller.Move(-transform.right * velocidad * Time.deltaTime);
        }
    }

    public void MoverAdelante()
    {
        adelante = true;
    }
    public void MoverAbajo()
    {
        atras = true;
    }
    public void MoverDerecha()
    {
        derecha = true;
    }
    public void MoverIzquierda()
    {
        izquierda = true;
    }


    public void desactivar()
    {
        adelante = false;
        atras = false;
        derecha = false;
        izquierda = false;
    }
}
