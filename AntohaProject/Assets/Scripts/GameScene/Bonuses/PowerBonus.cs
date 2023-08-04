using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerBonus : BaseBonus
{
    [SerializeField] private float powerValue;
    protected override void Activate(GameObject player)
    {
        player.GetComponent<PlayerPower>().AddAmount(powerValue);
    }
}
