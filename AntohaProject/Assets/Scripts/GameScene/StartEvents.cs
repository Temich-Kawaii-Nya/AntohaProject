using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartEvents : MonoBehaviour
{
    [SerializeField] private GameEvent startScene;
    [SerializeField] private GameEvent gameplay;
    private void Start()
    {
        startScene.Inint();
        gameplay.Inint();
    }
}
