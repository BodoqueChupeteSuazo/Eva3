using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlayer : MonoBehaviour
{
    public CharacterController controller;

    public float velocidad;
    public float velRotacion;
    public float rotationSpeed = 100.0f; 
    public float movementSpeed = 2.0f;
    private bool adelante;
    private bool atras;
    private bool derecha;
    private bool izquierda;
    private bool rotDerecha;
    private bool rotIZquierda;

    void Update()
    {
        if(adelante == true)
        {
            controller.Move(transform.forward * velocidad * Time.deltaTime);
        }

        if(atras==true)
        {
            controller.Move(-transform.forward * velocidad * Time.deltaTime);
        }

        if(derecha == true)
        {
            controller.Move(transform.right * velocidad * Time.deltaTime);
        }

        if(izquierda == true)
        {
            controller.Move(-transform.right * velocidad * Time.deltaTime);
        }

        if(rotDerecha == true)
        {
            transform.Rotate(0, Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed, 0);
        }

        if(rotIZquierda == true)
        {
            transform.Translate(0, 0, Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed);
        }
    }

    public void HaciaAdelante()
    {
        adelante = true;
    }
    public void HaciaAtras()
    {
        atras = true;
    }

    public void HaciaIzquierda()
    {
        izquierda = true;
    }
    public void HaciaDerecha()
    {
        derecha = true;
    }

    public void RotacionDerecha()
    {
        rotDerecha = true;
    }

    public void RotacionIzquierda()
    {
        rotIZquierda = true;
    }

    public void sinFuncion()
    {
        adelante = false;
        atras = false;
        derecha = false;
        izquierda = false;
        rotDerecha = false;
        rotIZquierda = false;
    }
}
