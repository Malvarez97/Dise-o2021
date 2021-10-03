using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccionEspera : MonoBehaviour
{
    private float x;
    private float y;
    public Animator animator;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("VelX", x);
        animator.SetFloat("VelY", y);
    }
}
