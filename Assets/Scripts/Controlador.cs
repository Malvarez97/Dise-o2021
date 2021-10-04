using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador : MonoBehaviour
{

    [SerializeField]
    private Canvas c1;
    [SerializeField]
    private Canvas c2;
    [SerializeField]
    private Playermode player;
    private float velocity;
    private float rotation;
    private bool activated = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)){
            c1.gameObject.SetActive(true);
            c2.gameObject.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.E)){
            c1.gameObject.SetActive(false);
            c2.gameObject.SetActive(true);
            velocity = player.getVelocityMov();
            rotation = player.getVelocityRot();
            player.setVelocityMov(0);
            player.setvelocityRot(0);
            player.removeAnimation();
        }
        if (Input.GetKeyDown(KeyCode.T)){
            c1.gameObject.SetActive(false);
            c2.gameObject.SetActive(false);
            player.setVelocityMov(velocity);
            player.setvelocityRot(rotation);
            player.createAnimation();
        }
    }
}
