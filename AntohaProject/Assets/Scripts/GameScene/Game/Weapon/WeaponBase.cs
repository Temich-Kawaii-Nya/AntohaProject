using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class WeaponBase : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefub;
    private WaitForSeconds wait;
    protected BulletPool bulletsPool;
    [SerializeField, Range(1, 20)] private int bulletsCount;
    private void Start()
    {
        bulletsPool = FindObjectOfType<BulletPool>();
        bulletsPool.AddBullets(bulletPrefub,bulletsCount);
    }
    public void Activate()
    {
        wait = new WaitForSeconds(0.5f);
        StartCoroutine(Timer());
    }

    private IEnumerator Timer()
    {
        while (true)
        {
            Shoot();
            yield return wait;
        }
    }
    protected abstract void Shoot();
}
