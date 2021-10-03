using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class ActionOraculo : MonoBehaviour, IAction
{
    [SerializeField]
    private Canvas canvas;
    [SerializeField]
    private Playermode player;
    private float velocity;
    private float rotation;


    public void Activate()
    {
        canvas.gameObject.SetActive(true);
        velocity = player.getVelocityMov();
        rotation = player.getVelocityRot();
        player.setVelocityMov(0);
        player.setvelocityRot(0);
    }
}
