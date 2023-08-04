using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private FloatingJoystick joystick;
    public static event Action OnBombPressed;
    public static event Action OnFired;
    public static event Action<Vector2> OnMove;
    private bool shotButtonPressed = false;
#if UnityEditor
#endif
    private void Update()
    {
        if (shotButtonPressed)
            OnFired?.Invoke();
        if(joystick.Horizontal != 0 || joystick.Vertical != 0)
        {
            OnMove?.Invoke(new Vector2(joystick.Horizontal, joystick.Vertical));
        }
        else
            OnMove?.Invoke(new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")));
        if (Input.GetKeyDown(KeyCode.X))
        {
            OnBombPressed?.Invoke();
        }
        if (Input.GetKey(KeyCode.Z))
        {
            OnFired?.Invoke();
        }
    }
    public void ShotPressed()
    {
        shotButtonPressed = true;
    }
    public void ShotUnPressed()
    {
        shotButtonPressed = false;
    }
}
