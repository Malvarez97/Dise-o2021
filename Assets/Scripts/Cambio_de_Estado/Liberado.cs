using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Liberado : MonoBehaviour
{

    public Dictionary<String,UnityEngine.Object> reglas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Liberado(Dictionary<String,UnityEngine.Object> reglas){
        this.reglas = reglas;
    }

    public void addRegla(String nombre, UnityEngine.Object valor){
        reglas.Add(nombre,valor);
    }

    public Dictionary<String,UnityEngine.Object> getReglas(){
        //copia de reglas?
        return reglas;
    }

    public void accionar(Accion a){
        //a.realizar();
    }





}
