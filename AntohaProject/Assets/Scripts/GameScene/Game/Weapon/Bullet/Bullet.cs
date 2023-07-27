using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Bullet : MonoBehaviour
{
    [SerializeField, Range(10, 50)] private float speed = 25f;
    [SerializeField] private Rigidbody2D rigidbody2D;
    private void FixedUpdate()
    {
        rigidbody2D.velocity = transform.up * speed;
    }
}
