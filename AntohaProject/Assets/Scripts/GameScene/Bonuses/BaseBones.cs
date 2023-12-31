using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BoxCollider2D))]
public class BaseBonus : MonoBehaviour
{
    [SerializeField] private int speed = 5;
    [SerializeField] private UnityEvent BonusActivated;
    private Transform target = null;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out PlayerMove player))
        {
            Activate(player.gameObject);
            BonusActivated.Invoke();
            gameObject.SetActive(false);
        }
    }

    protected virtual void Activate(GameObject player)
    {

    }
    private void Update()
    {
        if (target == null)
        {
            transform.Translate(speed * Time.deltaTime * Vector2.down);
            if (transform.position.y < new SafeAreaData().GetMin().y - 5f)
                gameObject.SetActive(false);
        }
        else
        {
            transform.position = Vector2.Lerp(transform.position, target.position, speed * 1.5f * Time.deltaTime);
        }
        
    }
    public void MoveToPlayer(Transform player)
    {
        target = player;
    }
}
