using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class IntScoreToText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    public void ChangeText(int value)
    {
        text.text = value.ToString();
    }
}
