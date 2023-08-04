using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
public class BombScript : MonoBehaviour
{
    [SerializeField] private ParticleSystem particle;
    [SerializeField] private CircleCollider2D collider;
    [Space]
    [SerializeField, Range(1, 10)] private float maxRadius;
    [SerializeField, Range(1, 50)] private float radiusSpeed;
    [SerializeField, Range(1, 50)] private float movementSpeed;
    [SerializeField, Range(1, 50)] private float durationTime;
    public static event Action<bool> OnBombEnded;
    private void Update()
    {
        if (gameObject.activeInHierarchy)
        {
            if (collider.radius < maxRadius)
            {
                collider.radius += radiusSpeed * Time.deltaTime;
            }
                transform.Translate(movementSpeed * Time.deltaTime * Vector2.up);
                StartCoroutine(SetDefault());
        }
    }
    private IEnumerator SetDefault()
    {
        yield return new WaitForSeconds(durationTime);
        OnBombEnded?.Invoke(false);
        collider.radius = 0.01f;
        particle.Stop();
        gameObject.SetActive(false);
    }
}
