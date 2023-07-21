using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelButtonPosition
{
    private Vector2 position;
    private float offsetY;
    public LevelButtonPosition()
    {
        SafeAreaData safeArea = new SafeAreaData();
        position = safeArea.GetMin();
        offsetY = position.x / 2; 
    }
    public Vector2 GetNextPosition()
    {
        position.x = offsetY;
        position.y += Mathf.Abs(offsetY);
        offsetY = -offsetY;
        return position;
    }
}
