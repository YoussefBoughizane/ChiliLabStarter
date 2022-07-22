using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;
using TMPro; 
public class TeleportationManager : MonoBehaviour
{

    [SerializeField]private InputActionAsset actionAsset;
    [SerializeField] private XRRayInteractor rayInteractor;
    [SerializeField] private TeleportationProvider provider;
    private InputAction thumbStick;
    private bool isActive; 
    
    // Start is called before the first frame update
    void Start()
    {
        setIsActive(false); 
        InputAction activate = actionAsset.FindActionMap("XRI LeftHand Locomotion").FindAction("Teleport Mode Activate");
        actionAsset.Enable();
        activate.performed += (e => setIsActive(true)); 
      
        InputAction cancel = actionAsset.FindActionMap("XRI LeftHand Locomotion").FindAction("Teleport Mode Cancel");
        cancel.Enable();
        cancel.performed += (e => setIsActive(false));


        thumbStick = actionAsset.FindActionMap("XRI LeftHand Locomotion").FindAction("Move");
        thumbStick.Enable();


    }


    private void Update()
    {

        if (!thumbStick.triggered && isActive)
            tryToTeleport(); 
    }

    private void tryToTeleport()
    {
     

        if ( rayInteractor.TryGetCurrent3DRaycastHit(out RaycastHit hit) &&  hit.transform.gameObject.GetComponent< BaseTeleportationInteractable>() != null )
        {
            TeleportRequest request = new TeleportRequest()
            {
                destinationPosition = hit.point
            };
            provider.QueueTeleportRequest(request);

            setIsActive(false);
        }


    }
        
    private void setIsActive(bool value )
    {
        isActive = value;
        rayInteractor.enabled = isActive;

    }


}
