using UnityEngine.AI;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D rb2d;
    [SerializeField] private float speed = 5f;
    private Vector2 direction;
    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        rb2d.MovePosition(rb2d.position + speed * Time.fixedDeltaTime * direction);
    }
    private void OnEnable()
    {
        PlayerInput.OnMove += SetDirection;
    }
    private void OnDisable()
    {
        PlayerInput.OnMove -= SetDirection;
    }
    private void SetDirection(Vector2 direction)
    {
        this.direction = direction;
    }

}