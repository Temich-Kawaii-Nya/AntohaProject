using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "level", menuName = "GameSO/level")]
public class LevelData : ScriptableObject
{
    public List<Wave> waves = new List<Wave>();
}
[System.Serializable]
public class Wave
{
    public GameObject enemyPrefub;
    [Range(1, 100)] public int countInWave;
    [Range(1, 600)] public int WaitAfterWave;
}
