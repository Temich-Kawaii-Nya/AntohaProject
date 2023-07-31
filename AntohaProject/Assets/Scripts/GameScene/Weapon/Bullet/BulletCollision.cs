using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CapsuleCollider2D))]
public class BulletCollision : MonoBehaviour
{
    [SerializeField, Range(100, 10000)] private int damage = 200;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.TryGetComponent(out IDamagable damagable))
        {
            damagable.TakeDamage(damage);
        }
        ResetObject();
    }

    private void ResetObject()
    {
        transform.rotation = Quaternion.identity;
        gameObject.SetActive(false);
    }
}
