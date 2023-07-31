using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPool : MonoBehaviour
{
    private readonly Dictionary<string,  List<GameObject>> bullets = new Dictionary<string, List<GameObject>>();
    public void AddBullets(GameObject prefub, int count)
    {
        if(bullets.ContainsKey(prefub.name) == false)
        {
            bullets.Add(prefub.name, new List<GameObject>());
        }
        for (int i = 0; i < count; i++)
        {
            Create(prefub);
        }
    }

    private GameObject Create(GameObject prefub)
    {
        var bullet = Instantiate(prefub, transform);
        bullet.SetActive(false);
        bullets[prefub.name].Add(bullet);

        return bullet;
    }

    public GameObject GetBullet(GameObject prefub)
    {
        if (bullets.ContainsKey(prefub.name))
        {
            for (int i = 0; i < bullets[prefub.name].Count; i++)
            {
                if (!bullets[prefub.name][i].activeInHierarchy)
                {
                    return bullets[prefub.name][i];
                }
            }
            return Create(prefub);
        }
        else
            bullets.Add(prefub.name, new List<GameObject>());
        return Create(prefub);
    }
}
