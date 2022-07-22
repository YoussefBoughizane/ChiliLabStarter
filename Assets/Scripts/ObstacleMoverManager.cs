using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit; 
public class ObstacleMoverManager : MonoBehaviour
{


    private XRDirectInteractor interactor;


    private void Start()
    {
        interactor = GetComponent<XRDirectInteractor>();
        interactor.selectEntered.AddListener(checkForPushInteraction); 
    }

    private void checkForPushInteraction(SelectEnterEventArgs e)
    {
        if( e.interactableObject.interactionLayers.ToString() == "pushables")
        {
            print("yay"); 
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
