using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerShot : MonoBehaviour
{
    [SerializeField, Range(0.1f, 1f)] private float shotInterval = 0.1f;
    [SerializeField] private UnityEvent OnShot;
    private WaitForSeconds wait;
    private bool isShoting;
    private void Awake()
    {
        wait = new WaitForSeconds(shotInterval);
    }
    private IEnumerator Timer()
    {
        if (!isShoting)
        {
            isShoting = true;
            OnShot.Invoke();
            yield return wait;
            isShoting = false;
        }
    }
    public void StartTimer()
    {
        StartCoroutine(Timer());
    }
    private void OnEnable()
    {
        PlayerInput.OnFired += StartTimer;
    }
    private void OnDisable()
    {
        PlayerInput.OnFired -= StartTimer;
    }
}
