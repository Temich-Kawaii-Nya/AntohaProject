using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPool : MonoBehaviour
{
    private readonly List<GameObject> bullets = new List<GameObject>();
    public void AddBullets(GameObject prefub, int count)
    {
        for (int i = 0; i < count; i++)
        {
            var bullet = Instantiate(prefub, transform);
            bullet.SetActive(false);
            bullets.Add(bullet);
        }
    }
    public GameObject GetBullet()
    {
        for (int i = 0; i < bullets.Count; i++)
        {
            if (!bullets[i].activeInHierarchy)
            {
                return bullets[i];
            }
        }
        return null;
    }
}
