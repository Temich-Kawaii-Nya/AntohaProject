using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWave : MonoBehaviour
{
    private LevelData levelData;
    private int indexWave;
    private int indexEnemy;
    private List<GameObject> enemies = new List<GameObject>();
    private void Awake()
    {
        int index = new LevelNameData().GetLevelIndex();
        levelData = Resources.Load<LevelData>($"Levels/Level{index}");
    }
    public void Activate()
    {
        StartCoroutine(ActivateEnemy()); 
    }
    public PathData GetPath()
    {
        return levelData.waves[indexWave].Path;
    }
    public void Generate()
    {
        int offset = 1;
        Vector2 startPosition = new Vector2(0, new SafeAreaData().GetMax().y + offset);
        foreach (var wave in levelData.waves)
        {
            for (int  i = 0;  i < wave.CountInWave;  i++)
            {
                var enemy = Instantiate(wave.EnemyPrefub, transform);
                enemy.transform.position = startPosition; 
                enemy.SetActive(false);
                enemy.GetComponent<EnemiesMovement>().SetPath(wave.Path);
                enemies.Add(enemy);
            }
        }
    }
    public IEnumerator ActivateEnemy()
    {
        WaitForSeconds wait = new WaitForSeconds(0.5f);
        var count = levelData.waves[indexWave].CountInWave;
        while(count > 0)
        {
            count--;
            enemies[indexEnemy].gameObject.SetActive(true);
            indexEnemy++;
            yield return wait;
        }
        if (indexWave < levelData.waves.Count - 1)
        {
            Invoke(nameof(Activate), levelData.waves[indexWave].WaitAfterWave);
            indexWave++;
        }
    }
}
