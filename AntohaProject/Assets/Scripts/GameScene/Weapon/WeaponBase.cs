using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class WeaponBase : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefub;
    protected BulletPool bulletsPool;
    [SerializeField, Range(0, 20)] private int bulletsCount;
    private void OnEnable()
    {
        if (bulletsPool == null)
            bulletsPool = FindObjectOfType<BulletPool>();
        if (bulletsCount > 0)
            bulletsPool.AddBullets(bulletPrefub,bulletsCount);
    }
    protected void BulletActivate(Transform bulletStartPos)
    {
        var bullet = bulletsPool.GetBullet(bulletPrefub);
        bullet.transform.position = bulletStartPos.position;
        bullet.transform.Rotate(transform.rotation.eulerAngles);
        bullet.SetActive(true);
    }
    public abstract void Shot();
}
