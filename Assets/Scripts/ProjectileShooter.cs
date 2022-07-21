using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit; 

public class ProjectileShooter : MonoBehaviour
{
    [SerializeField]private float projectileForce;
    [SerializeField] private GameObject controller;
    [SerializeField] protected int maxProjectiles = 10; 
    protected virtual GameObject currentProjectile { get; set; }
    private XRGrabInteractable interactable;
    public void Start()
    {
        interactable = GetComponent<XRGrabInteractable>(); 
        interactable.activated.AddListener(onActivateShoot); 
    }

    private void onActivateShoot(ActivateEventArgs arg0)
    {
        shoot(); 
    }



    protected virtual void shoot()
    {
        currentProjectile.GetComponent<Projectile>().launch(projectileForce); 
    }
}
