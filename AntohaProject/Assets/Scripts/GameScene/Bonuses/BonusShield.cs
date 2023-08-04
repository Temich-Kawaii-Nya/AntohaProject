using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusShield : BaseBonus
{
    [SerializeField] private Shield shield;
    [SerializeField] private float liveTime = 3f;
    private Shield currentBonus;
    private void CheckShield()
    {
        if (currentBonus == null)
            currentBonus = Instantiate(shield);
    }
    protected override void Activate(GameObject player)
    {
        CheckShield();
        if (!currentBonus.IsEnabled)
        {
            currentBonus.gameObject.transform.position = player.transform.position;
            currentBonus.gameObject.transform.SetParent(player.transform);
        }
        currentBonus.Activate(liveTime);
    }
}
