using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckInteraction : MonoBehaviour
{

    public enum TypeOfDetection
    {
        PointToReceiver,
        Radial3DNoDirection,
    };

    [SerializeField]
    private TypeOfDetection typeOfDetection;

    [SerializeField]
    private float minInteractionDistance;
   
    [SerializeField]
    private GameObject rayOrigin;


    private Ray ray;

    private bool canInteract;

    private InteractionReceiver currentReceiver;
    [SerializeField]
    private GameObject ui;

    private void Start()
    {
        if (typeOfDetection == TypeOfDetection.Radial3DNoDirection)
        {
            if (GetComponent<Rigidbody>()==null)
            {
                Debug.Log("The GameObject with the CheckInteraction Script requires a RigidBody component");
                Debug.Break();

            }
            if (GetComponent<SphereCollider>() == null)
            {
                Debug.Log("The GameObject with the CheckInteraction Script requires a SphereCollider component");
                Debug.Break();
            }
        }

    }

    void Update()
    {
        if (typeOfDetection == TypeOfDetection.PointToReceiver)
        {
            CheckRaycast();
        }

        if (canInteract)
        {
            ui.GetComponent<Text>().text = currentReceiver.GetInteractionMessage();
            ui.SetActive(true);
            Debug.Log("Puedo interactuar");

            if (Input.GetKey(KeyCode.E))
            {
                Debug.Log("Estoy interactuando");
                currentReceiver.Activate();
            }
        }
    }

    private void CheckRaycast()
    {
        ray = new Ray(rayOrigin.transform.position, rayOrigin.transform.forward);

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.distance < minInteractionDistance)
            {
                currentReceiver = hit.transform.gameObject.GetComponent<InteractionReceiver>();
                if (currentReceiver != null)
                {
                    DetectingAReceiver();                 
                }
                else
                {
                    canInteract = false;
                }
            }
        }
    }

    private void DetectingAReceiver()
    {
        canInteract = true;
        Debug.Log(currentReceiver.GetInteractionMessage());

    }

    private void OnTriggerStay(Collider other)
    {
        if (typeOfDetection == TypeOfDetection.Radial3DNoDirection)
        {
            if (other.gameObject.GetComponent<InteractionReceiver>() != null)
            {
                currentReceiver = other.gameObject.GetComponent<InteractionReceiver>();
                DetectingAReceiver();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (typeOfDetection == TypeOfDetection.Radial3DNoDirection)
        {
            if (other.gameObject.GetComponent<InteractionReceiver>() != null)
            {
               
                currentReceiver =null;
            
                canInteract = false;
            }
        }
    }


}
