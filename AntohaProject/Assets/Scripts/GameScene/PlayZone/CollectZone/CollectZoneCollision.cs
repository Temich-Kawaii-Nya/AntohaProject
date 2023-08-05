using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectZoneCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.TryGetComponent(out PlayerCollect player))
        {
            player.SetMaxRadius();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out PlayerCollect player))
        {
            player.SetDefaultRadius();
        }
    }
}
