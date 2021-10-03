using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Personaje : MonoBehaviour
{
    //Implementa IOperador
    private Dictionary<String,Accion> acciones;
    private Dictionary<String,UnityEngine.Object> caracteristicas;
    private Computadora cActual;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*public Personaje(Computadora computadora){
        this.cActual = computadora;
    }*/

    public void accionar(String s, Computadora c){
        //accionar
    }

    public void ordenar(Orden o){
        //orden
    }

    public void responderSolicitud(Orden o){
        //responder solicitud
    }
}
