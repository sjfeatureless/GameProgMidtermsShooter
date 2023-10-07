using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public Transform bulletSpawnLoc;
    public GameObject bulletPrefab;
    public float bulletSpeed = 1f;
    public float fireRate = 1;
    private float baseFireRate;

    void Start()
    {
        baseFireRate = fireRate;
    }

    void Update()
    {
        fireRate -= Time.deltaTime;

        if (fireRate <= 0)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnLoc.position, bulletSpawnLoc.rotation);
        Rigidbody bulletRB = bullet.GetComponent<Rigidbody>();
        bulletRB.AddForce(bulletSpawnLoc.forward * bulletSpeed, ForceMode.Impulse);
        fireRate = baseFireRate;
    }
}
