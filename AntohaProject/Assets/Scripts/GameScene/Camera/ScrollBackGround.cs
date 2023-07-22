using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBackGround : MonoBehaviour
{
    [SerializeField] private SpriteRenderer sprite;
    private float speed = 2f;
    private float positionMinY;
    private Vector2 restartPosition;
    private void Awake()
    {
        restartPosition = transform.position = new Vector2(transform.position.x, new SafeAreaData().GetMin().y);
        positionMinY = sprite.bounds.size.y * 2 - restartPosition.y;
    }
    private void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector2.down);
        if(transform.position.y <= -positionMinY)
        {
            transform.position = restartPosition;
        }
    }
}
