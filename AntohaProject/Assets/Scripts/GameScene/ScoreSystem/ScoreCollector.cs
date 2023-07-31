using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScoreCollector : MonoBehaviour
{
    [SerializeField] private UnityEvent<int> ScoreChanged;
    private int scoreCollected = 0;
    private void Awake()
    {
        ScoreChanged.Invoke(scoreCollected);
    }
    private void OnEnable()
    {
        ScoreObject.OnChanged += OnScoreChanged;
    }
    private void OnDisable()
    {
        ScoreObject.OnChanged -= OnScoreChanged;
    }
    private void OnScoreChanged(int value)
    {
        scoreCollected += value;
        ScoreChanged.Invoke(scoreCollected);
    }
}
