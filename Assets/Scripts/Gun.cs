using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : ProjectileShooter
{

    [SerializeField]private GameObject bulletPrefab;

    [SerializeField] private Transform spawnPosition;

    List<GameObject> bullets = new List<GameObject>(); 
    private int bulletIndex = 0; 
    public new void Start()
    {
        base.Start(); 
        for (int i = 0; i < maxProjectiles; i++)
        {
            bullets.Add(Instantiate(bulletPrefab, spawnPosition.position, gameObject.transform.rotation));
            bullets[i].SetActive(false); 
        }
    }

    override protected void shoot()
    {

        currentProjectile = bullets[bulletIndex];
        currentProjectile.transform.position = spawnPosition.position;
        currentProjectile.transform.rotation= spawnPosition.rotation;
        currentProjectile.SetActive(true);
        print("shoot");
        bulletIndex++;
        bulletIndex %= bullets.Count;
        base.shoot();

    }
}
