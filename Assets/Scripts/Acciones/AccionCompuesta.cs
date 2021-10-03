using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccionCompuesta : MonoBehaviour
{

    private Accion a1,a2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public AccionCompuesta(Accion a1, Accion a2){
        this.a1 = a1;
        this.a2 = a2;
    }

    public void realizar(Personaje p, Computadora comp){
        //realizar
    }
}
