using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class BoarderSize : MonoBehaviour
{
    [SerializeField] private Camera camera;
    private const float FullSize = 20f;
    private void Start()
    {
        SetSize();
    }
    private void SetSize()
    {
        float yScale = camera.ScreenToWorldPoint(Screen.safeArea.max).y * FullSize;
        BoxCollider2D boxCollider2D = GetComponent<BoxCollider2D>();
        boxCollider2D.size = new Vector2(boxCollider2D.size.x, yScale);
    }
}
