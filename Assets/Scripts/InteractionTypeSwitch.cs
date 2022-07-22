using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class InteractionTypeSwitch : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private ActionBasedController controller;

    [SerializeField] private XRRayInteractor rayInteractor;
    private XRDirectInteractor directInteractor;
    void Start()
    {
        directInteractor = GetComponent<XRDirectInteractor>(); 
        controller.activateAction.action.performed += enableRayInteractor;
        controller.activateAction.action.canceled += disableRayInteractor; 
    }

    private void enableRayInteractor(InputAction.CallbackContext action)
    {
        
        if (!controller.selectAction.action.IsPressed() ) { 
        directInteractor.enabled = false;
        rayInteractor.enabled = true;
        }

    }


    private void disableRayInteractor(InputAction.CallbackContext action)
    {
        if ( !controller.selectAction.action.IsPressed()) 
        {
            rayInteractor.enabled = false;
            directInteractor.enabled = true;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
