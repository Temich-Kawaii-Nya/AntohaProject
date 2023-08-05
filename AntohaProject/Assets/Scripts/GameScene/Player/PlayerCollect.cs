using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollect : MonoBehaviour
{
    [SerializeField] private CircleCollider2D collider;
    [SerializeField, Range(1, 100)] private float maxRadius;
    [SerializeField, Range(1, 20)] private float defaultRadius;
    private void Awake()
    {
        SetDefaultRadius();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out BaseBonus bonus))
        {
            bonus.MoveToPlayer(transform);
        }
    }
    public void SetMaxRadius()
    {
        collider.radius = maxRadius;
    }
    public void SetDefaultRadius()
    {
        collider.radius = defaultRadius;
    }
}
