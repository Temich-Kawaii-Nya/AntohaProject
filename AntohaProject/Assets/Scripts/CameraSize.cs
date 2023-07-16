using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraSize : MonoBehaviour
{
    private const float DefaultWidth = 1080f;
    private void Awake()
    {
         GetComponent<Camera>().orthographicSize = DefaultWidth * Screen.height / Screen.width / 200f;
    }
}
