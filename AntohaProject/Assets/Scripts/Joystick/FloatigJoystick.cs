using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(RectTransform))]
public class FloatigJoystick : MonoBehaviour
{
    public RectTransform Knob;
    [HideInInspector] public RectTransform RectTransform;
    private void Awake()
    {
        RectTransform = GetComponent<RectTransform>();
    }
}
