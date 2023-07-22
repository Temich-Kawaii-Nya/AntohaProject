using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesMovement : MonoBehaviour
{
    private float speed = 5f;
    private float offset = 3f;
    private float endPosition;
    private void Start()
    {
        endPosition = new SafeAreaData().GetMin().y - offset;
    }
    private void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector2.down);
        if (transform.position.y < endPosition)
        {
            Destroy(gameObject);
        }
    }
}
