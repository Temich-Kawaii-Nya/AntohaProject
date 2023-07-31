using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HealthObject : MonoBehaviour, IDamagable
{
    [SerializeField, Range(1, 10000)] private int maxHealth = 100;
    private int currentHealth;
    [SerializeField] private UnityEvent OnHealthsEnded; 

    protected int GetCurrentHeath()
    {
        return currentHealth;
    }
    public virtual void TakeDamage(int value)
    {
        currentHealth -= value;
        if (currentHealth <= 0)
        {
            OnHealthsEnded.Invoke();
        }
    }
    protected virtual void OnEnable()
    {
        currentHealth = maxHealth;
    }
    public void AddHealth(int value)
    {
        if (value > 0)
        {
            currentHealth += value;
            if (currentHealth > maxHealth)
                GetExtraHealth(maxHealth % currentHealth);
        }
    }
    private void GetExtraHealth(int value)
    {
        maxHealth += value;
    }
}
