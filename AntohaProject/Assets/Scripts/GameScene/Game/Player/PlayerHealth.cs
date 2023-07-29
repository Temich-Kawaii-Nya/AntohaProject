using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : HealthObject
{
    [SerializeField] private UnityEvent<int> OnChangeHealth;
    protected override void OnEnable()
    {
        base.OnEnable();
        OnChangeHealth.Invoke(GetCurrentHeath());
    }
    public override void TakeDamage(int value)
    {
        base.TakeDamage(value);
        OnChangeHealth.Invoke(GetCurrentHeath());
    }
    public void PrintHeath()
    {
        Debug.Log(GetCurrentHeath());
    }
}
