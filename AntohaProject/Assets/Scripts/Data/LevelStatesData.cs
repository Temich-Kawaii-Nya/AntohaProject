using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStatesData : MonoBehaviour
{
    private const string Key = "LevelStateData";
    public void Save(LevelButtonsStates states)
    {
        PlayerPrefs.SetString(Key, JsonUtility.ToJson(states));
        PlayerPrefs.Save();
    }
    public LevelButtonsStates Load()
    {
        if (PlayerPrefs.HasKey(Key))
            return JsonUtility.FromJson<LevelButtonsStates>(PlayerPrefs.GetString(Key));
        return null;
    }
}
