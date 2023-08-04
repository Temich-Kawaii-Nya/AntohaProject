using System;
using System.Collections;
using UnityEngine;

public class Shield : MonoBehaviour
{
    [SerializeField] private CircleCollider2D collider;
    [SerializeField] private SpriteRenderer sprite;
    private float currentTime;
    private bool isEnable;
    public bool IsEnabled => isEnable;
    public void Activate(float timer)
    {
        currentTime += timer;
        if (!isEnable)
        {
            Show(true);
            StartCoroutine(Timer());
        }
    }

    private void Show(bool value)
    {
        collider.enabled = value;
        sprite.enabled = value;
        isEnable = value;
    }
    private IEnumerator Timer()
    {
        float step = 0.5f;
        WaitForSeconds wait = new WaitForSeconds(step);
        while(currentTime > 0)
        {
            currentTime -= step;
            yield return new WaitForSeconds(step);
        }
        currentTime = 0;
        Show(false);
        transform.SetParent(null);
    }
}
