using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombController : MonoBehaviour
{
    [SerializeField, Range(1, 5)] private int cost;
    [SerializeField] private GameObject bomb;
    [SerializeField] private PlayerPower power;
    private bool isActive;
    private void Awake()
    {
        SetActive(false);
    }
    public void Activate()
    {
        if (power.GetAmount() - cost >= 1 && !isActive)
        {
            bomb.transform.position = transform.position;
            power.AddAmount(-cost);
            SetActive(true);
        }
    }
    private void SetActive(bool value)
    {
        isActive = value;
        bomb.SetActive(value);
    }
    private void OnEnable()
    {
        PlayerInput.OnBombPressed += Activate;
        BombScript.OnBombEnded += SetActive;
    }
    private void OnDisable()
    {
        BombScript.OnBombEnded -= SetActive;
        PlayerInput.OnBombPressed -= Activate;
    }
}
