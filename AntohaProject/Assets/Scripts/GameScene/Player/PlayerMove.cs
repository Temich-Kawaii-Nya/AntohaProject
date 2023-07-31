using UnityEngine.AI;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMove : MonoBehaviour
{
    [SerializeField] private FloatingJoystick joystick;
    private Rigidbody2D rb2d;
    private float speed = 5f;
    private Vector2 direction;
    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        if(joystick.Horizontal != 0 || joystick.Vertical != 0)
        {
            direction.x = joystick.Horizontal;
            direction.y = joystick.Vertical;
            rb2d.MovePosition(rb2d.position + speed * Time.fixedDeltaTime * direction);
        }
    }

}