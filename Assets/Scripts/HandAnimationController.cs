using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using TMPro; 
public class HandAnimationController : MonoBehaviour
{

    [SerializeField] private ActionBasedController controller;
    [SerializeField] private Animator animator;
    [SerializeField] private float speed; 


    private float targetGrip, currentGrip;
    private float currentTrigger, targetTrigger; 
    // Start is called before the first frame update
    void Start()
    {


        controller.selectAction.action.performed += (e => targetGrip = e.ReadValue<float>());
        controller.selectAction.action.canceled += (e => targetGrip = 0);


        controller.activateAction.action.performed += (e =>targetTrigger =  e.ReadValue<float>());
        controller.activateAction.action.canceled += (e => targetTrigger = 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentGrip != targetGrip)
        {
            currentGrip = Mathf.MoveTowards(currentGrip, targetGrip, 0.1f);
            animator.SetFloat("Grip", currentGrip); 
        }
        if (currentTrigger != targetTrigger)
        {
            currentTrigger = Mathf.MoveTowards(currentTrigger, targetTrigger, 0.1f);
            animator.SetFloat("Trigger", currentTrigger);
        }
    }
}
