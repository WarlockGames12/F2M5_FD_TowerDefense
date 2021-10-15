using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float timer = 0.3f;
    public float bulletForce = 20f;

    private Bullet pi;

    public void Shoot()
    {
        pi = GetComponent<Bullet>();
        Invoke("Commit", timer);
    }

    void Commit()
    {

        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Bullet bullet1 = bullet.GetComponent<Bullet>();


    }
}
