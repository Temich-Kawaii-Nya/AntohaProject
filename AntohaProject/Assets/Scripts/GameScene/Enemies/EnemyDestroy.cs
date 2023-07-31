using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroy : MonoBehaviour
{
    public void DestoyObject()
    {
        Destroy(gameObject, 0.01f);
    }
}
