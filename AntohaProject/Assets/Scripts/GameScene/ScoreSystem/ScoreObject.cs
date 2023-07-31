using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreObject : MonoBehaviour
{
    public static event Action<int> OnChanged;
    [SerializeField, Range(100, 10000)] private int score;
    public void Activate()
    {
        OnChanged?.Invoke(score);
    }
}
