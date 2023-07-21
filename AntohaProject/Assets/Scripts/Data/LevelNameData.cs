using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelNameData
{
    private const string NameKey = "SceneName";
    private const string IndexKey = "Index";
    public void SetName(string name)
    {
        PlayerPrefs.SetString(NameKey, name);
        PlayerPrefs.Save();
    }
    public string GetName()
    {
        if (PlayerPrefs.HasKey(NameKey))
        {
            return PlayerPrefs.GetString(NameKey);
        }
        return null;
    }
    public void SetLevelIndex(int value)
    {
        PlayerPrefs.SetInt(IndexKey, value);
        PlayerPrefs.Save();
    }
    public int GetLevelIndex()
    {
        if (PlayerPrefs.HasKey(IndexKey))
            return PlayerPrefs.GetInt(IndexKey);
        return 0;
    }
}
