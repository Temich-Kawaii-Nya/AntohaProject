using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class IntToText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    public void ChangeText(float value)
    {
        text.text = value.ToString("0.00");
    }
    public void ChangeText(int value)
    {
        text.text = value.ToString();
    }
}
