using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleWeapon : WeaponBase
{
    [SerializeField] private List<Transform> bulletStart;

    public override void Shot()
    {
        foreach (var item in bulletStart)
        {
            BulletActivate(item);
        }
    }
}
