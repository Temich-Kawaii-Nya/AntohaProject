using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombCollision : MonoBehaviour
{
    [SerializeField, Range(1, 10000)] private int damage;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out IDamagable damagable))
        {
            damagable.TakeDamage(damage);
        }
        if (collision.TryGetComponent(out Bullet bullet))
        {
            bullet.gameObject.SetActive(false);
        }
    }
}
