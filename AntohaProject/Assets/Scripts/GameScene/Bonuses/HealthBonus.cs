using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(BoxCollider2D))]
public class HealthBonus : BaseBonus
{
    [SerializeField, Range(1, 3)] private int health = 1;
    protected override void Activate(GameObject player)
    {
        if(player.TryGetComponent(out PlayerHealth playerHealth))
        {
            playerHealth.AddHealth(health);
            playerHealth.PrintHeath();
        }
    }
}
