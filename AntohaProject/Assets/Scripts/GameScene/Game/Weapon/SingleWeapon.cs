using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleWeapon : WeaponBase
{
    [SerializeField] private Transform bulletStartPosition;
    protected override void Shoot()
    {
        var bullet = bulletsPool.GetBullet();
        if (bullet != null)
        {
            bullet.transform.position = bulletStartPosition.position;
            bullet.transform.Rotate(transform.rotation.eulerAngles);
            bullet.SetActive(true);
        }
        else
            Debug.Log("Null Bullet!");
    }
}
