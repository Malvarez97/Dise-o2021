using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermode : MonoBehaviour
{
    public float velocityMov = 5.0f;
    public float velocityRot = 200.0f;
    private Animator anim;
    public float x, y; // como se mueve el personaje ;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        transform.Rotate(0, x * Time.deltaTime * velocityRot, 0);
        transform.Translate(0, 0, y * Time.deltaTime * velocityMov);
        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);
    }

    public void setVelocityMov(float velmov){
        velocityMov = velmov;
    }

    public float getVelocityMov(){
        return velocityMov;
    }

    public void setvelocityRot(float velrot){
        velocityRot = velrot;
    }

    public float getVelocityRot(){
        return velocityRot;
    }

    public void removeAnimation(){
        anim.SetFloat("VelX", 0);
        anim.SetFloat("VelY", 0);
    }

    public void createAnimation(){
        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);
    }
}
