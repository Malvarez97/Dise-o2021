using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class RegistrationController : MonoBehaviour
{
    /*
    private String usuario;
    private String contrasenia;
    */

    private Dictionary<String,String> cuenta;
    [SerializeField]
    private Text usuario;
    [SerializeField]
    private Text contrasenia;
    [SerializeField]
    private Text verificacionContrasenia;

    // Start is called before the first frame update
    void Start()
    {
        /*
        usuario = "admin";
        contrasenia = "admin";

        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void crearCuenta(){
        if (contrasenia.text == verificacionContrasenia.text)
        {
            //Las contraseñas son iguales
        }
        if (!cuenta.ContainsKey(usuario.text))
        {
            cuenta.Add(usuario.text,contrasenia.text);
        }
        else
        {
            
        }

    }
}
