using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleWeapon : WeaponBase
{
    [SerializeField] private Transform bulletStartPosition;
    public override void Shot()
    {
        BulletActivate(bulletStartPosition);
    }
}
