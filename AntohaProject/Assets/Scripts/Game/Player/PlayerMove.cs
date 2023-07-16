using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMove : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb2d =null;
    private float speed = 5f;
    private Vector2 direction = Vector2.zero;
    private void FixedUpdate()
    {
#if UNITY_EDITOR
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");
#else
#endif
        rb2d.MovePosition(rb2d.position + speed * Time.deltaTime * direction);

    }
}
