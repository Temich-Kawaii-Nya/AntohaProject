using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSystem : MonoBehaviour
{
    private int level = 1;
    [SerializeField] private List<GameObject> weapons = new List<GameObject>();

    private void Awake()
    {
        level = 1;
        SetWeapon(level);
    }
    //private void OnEnable()
    //{
    //    PlayerPower.OnValueChanged += CheckLevel;
    //}
    //private void OnDisable()
    //{
    //    PlayerPower.OnValueChanged -= CheckLevel;
    //}
    public void CheckLevel(float value)
    {
        int tempLevel = Mathf.FloorToInt(value);
        switch (tempLevel)
        {
            case 1:
                level = 1;
                Debug.Log(level);
                break;
            case 2:
                level = 2;
                Debug.Log(level);
                break;
            case 3:
                level = 3;
                Debug.Log(level);
                break;
            case 4:
                level = 4;
                Debug.Log(level);
                break;
            case 5:
                level = 5;
                Debug.Log(level);
                break;
        }
        SetWeapon(level);
    }

    private void SetWeapon(int level)
    {
        for (int i = 0; i < weapons.Count; i++)
        {
            if (i < level)
                weapons[i].gameObject.SetActive(true);
            else
                weapons[i].gameObject.SetActive(false);
        }
    }
}
