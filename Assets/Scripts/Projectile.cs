using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
     
    public void launch(float force)
    {
        print(force); 
        GetComponent<Rigidbody>().AddForce(transform.forward* force); 
    }
}
