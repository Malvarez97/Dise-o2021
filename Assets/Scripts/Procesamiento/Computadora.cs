using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Computadora : MonoBehaviour
{
    private System.Collections.Generic.List<Personaje> personajesConectados;
    private System.Collections.Generic.List<Programa> programas;
    private System.Collections.Generic.List<Orden> ordenes;
    //private System.Collections.Generic.List<Simulacion> simulaciones;
    private Simulacion matrix;
    private IOperador operador;
    //private Motor motor; VA EL MOTOR?
    private Simulacion simulacionActual;

    // Start is called before the first frame update
    void Start()
    {
           
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addPrograma(Programa p){
        programas.Add(p);
    }

    public void accionPersonaje(Personaje p, Accion a){
        //p.accionar(a);
    }

    /*public void ejecutarSimulacion(Simulacion s){
        if (simulaciones.Contains(s))
            simulacionActual = s;
    }*/

    public void ejecutarSimulacion(){
        //matrix;
    }

    //Un personaje se quiere conectar a la computadora
    public void conectarse(Personaje p){
        personajesConectados.Add(p);
    }

}

