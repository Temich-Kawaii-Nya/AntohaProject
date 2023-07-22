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
    public void Generate()
    {
        foreach (var wave in levelData.waves)
        {
            for (int  i = 0;  i < wave.countInWave;  i++)
            {
                var enemy = Instantiate(wave.enemyPrefub, transform);
                enemy.SetActive(false);
                enemies.Add(enemy);
            }
        }
    }
    public IEnumerator ActivateEnemy()
    {
        WaitForSeconds wait = new WaitForSeconds(0.5f);
        var count = levelData.waves[indexWave].countInWave;
         
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
