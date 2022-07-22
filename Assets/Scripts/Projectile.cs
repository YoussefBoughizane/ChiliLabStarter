using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
     
    public void launch(Vector3 force)
    {
        GetComponent<Rigidbody>().AddForce(force); 
    }
}
