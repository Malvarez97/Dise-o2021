using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Simulacion : MonoBehaviour
{
    private Dictionary<String,UnityEngine.Object> reglas;
    private System.Collections.Generic.List<Personaje> personajes;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Simulacion(){
        //constructor simulacion
    }

    public void aniadirPersonaje(Personaje p){
        personajes.Add(p);
    }

    public void eliminarPersonaje(Personaje p){
        personajes.Remove(p);
    }

    public void aniadirRegla(String nombre, UnityEngine.Object regla){
        reglas.Add(nombre,regla);
    }

    public void eliminarRegla(String nombre){
        reglas.Remove(nombre);
    }

    public Dictionary<String,UnityEngine.Object> getReglas(){
        //copia de reglas?
        return reglas;
    }

}
