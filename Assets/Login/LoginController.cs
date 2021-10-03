using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoginController : MonoBehaviour
{

    private Dictionary<String,String> cuentas;
    [SerializeField]
    private string escena;
    [SerializeField]
    private Text usuario;
    [SerializeField]
    private Text contrasenia;

    void Start(){
    }
    
    public void login(){
        //if (cuentas.ContainsKey(usuario.text)){
            //if (cuentas.ContainsValue(contrasenia.text))
                SceneManager.LoadScene(escena);
        //}
    }



}
