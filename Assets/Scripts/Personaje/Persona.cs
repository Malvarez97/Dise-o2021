using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Persona : Personaje
{

    public TipoPersona tipoPersona;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Persona(TipoPersona tp){
        this.tipoPersona = tp;
    }

}
