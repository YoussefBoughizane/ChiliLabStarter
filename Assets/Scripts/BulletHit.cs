using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; 
public class BulletHit : MonoBehaviour
{
    private const string bullet = "bullet";

    public Action<GameObject> whenHitWithBullet; 
    private void OnCollisionEnter(Collision collision)
    {

        if( collision.collider.tag == bullet)
        {

            whenHitWithBullet.Invoke(gameObject); 

        } 
    }
}
