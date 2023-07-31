using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalBoardPos : MonoBehaviour
{
    [SerializeField] private Camera camera;
    [SerializeField] private bool isUp;
    private void Start()
    {
        SetPosition();
    }
    private void SetPosition()
    {
        Vector2 safePosition = isUp ? Screen.safeArea.max : Screen.safeArea.min;
        float positionY = camera.ScreenToWorldPoint(safePosition).y;
        transform.position = new Vector2(transform.position.x, positionY);
    }
}
