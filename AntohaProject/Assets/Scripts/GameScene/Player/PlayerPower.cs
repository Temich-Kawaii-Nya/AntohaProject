using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerPower : MonoBehaviour
{
    private float powerAmount = 1;
    [SerializeField] private UnityEvent<float> OnChanged;
    private void Awake()
    {
        OnChanged.Invoke(powerAmount);
    }
    public float GetAmount() => powerAmount;
    public void AddAmount(float value)
    {
        powerAmount = Mathf.Clamp(powerAmount + value, 1, 5);
        OnChanged.Invoke(powerAmount);
    }
    public void SetDefaultValue()
    {
        powerAmount = 1;
    }
}
