using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit; 
public class HandAnimationController : MonoBehaviour
{

    [SerializeField] private ActionBasedController controller;
    [SerializeField] private Animator animator;

    private float grip;
    private float trigger; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        grip = controller.selectAction.action.ReadValue<float>();
        animator.SetFloat("Grip", grip);

        trigger = controller.activateAction.action.ReadValue<float>();
        animator.SetFloat("Trigger", trigger);
    }
}
