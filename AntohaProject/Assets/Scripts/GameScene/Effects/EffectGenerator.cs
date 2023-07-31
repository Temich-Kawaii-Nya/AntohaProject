using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectGenerator : MonoBehaviour
{
    private const int DefaultCount = 3;
    [SerializeField] private ParticleSystem prefub;
    private List<GameObject> effects = new List<GameObject>();
    private void Awake()
    {
        for (int i = 0; i < DefaultCount; i++)
        {
            Create();
        }
    }

    private GameObject Create()
    {
        GameObject effect = Instantiate(prefub.gameObject, transform);
        effects.Add(effect);
        return effect;
    }
    public GameObject GetEffect()
    {
        foreach (var item in effects)
        {
            if (!item.activeInHierarchy)
                return item;
        }
        return Create();
    }
}
