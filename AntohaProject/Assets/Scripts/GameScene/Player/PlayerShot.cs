using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerShot : MonoBehaviour
{
    [SerializeField, Range(0.1f, 1f)] private float shotInterval = 0.5f;
    [SerializeField] private UnityEvent OnShot;
    private WaitForSeconds wait;
    private IEnumerator Timer()
    {
        while (true)
        {
            OnShot.Invoke();
            yield return wait;
        }
    }
    public void StartTimer()
    {
        wait = new WaitForSeconds(shotInterval);
        StartCoroutine(Timer());
    }
}
