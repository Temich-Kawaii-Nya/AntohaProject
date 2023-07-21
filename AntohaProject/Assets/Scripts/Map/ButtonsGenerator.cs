using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonsGenerator : MonoBehaviour
{
    [SerializeField] private MapButton buttonPlayable;
    [SerializeField] private GameObject buttonLocked;
    [SerializeField] private GameObject path;
    [SerializeField] private Sprite[] sprites;
    [SerializeField] private UnityEvent OnGenerated;
    private void Start()
    {
        Generate();
    }

    private void Generate()
    {
        LevelButtonsStates levelStates = new LevelButtonsStates();
        levelStates.States.Add(LevelState.Locked);
        levelStates.States.Add(LevelState.Open);
        levelStates.States.Add(LevelState.OneStar);
        levelStates.States.Add(LevelState.TwoStars);
        levelStates.States.Add(LevelState.ThreeStars);
        levelStates.States.Add(LevelState.ThreeStars);
        levelStates.States.Add(LevelState.ThreeStars);

        LevelButtonPosition buttonPosition = new LevelButtonPosition();
        Vector2 currentPosition;
        List<Vector2> buttonPositions = new List<Vector2>();
        for (int i = 0; i < levelStates.States.Count; i++)
        {
            currentPosition = buttonPosition.GetNextPosition();
            buttonPositions.Add(currentPosition);
            if (levelStates.States[i] == LevelState.Locked)
                Instantiate(buttonLocked, transform).transform.position = currentPosition;
            else
            {
                MapButton button = Instantiate(buttonPlayable, transform);
                button.transform.position = currentPosition;
                Sprite sprite = null;
                switch (levelStates.States[i])
                {
                    case LevelState.Open:
                        sprite = sprites[1];
                        break;
                    case LevelState.OneStar:
                        sprite = sprites[2];
                        break;
                    case LevelState.TwoStars:
                        sprite = sprites[3];
                        break;
                    case LevelState.ThreeStars:
                        sprite = sprites[4];
                        break;
                }
                button.SetValues(sprite, i);
            }
        }
        for (int i = 0; i < buttonPositions.Count - 1; i++)
        {
            currentPosition = (buttonPositions[i] + buttonPositions[i + 1]) / 2;
            var pathObject = Instantiate(path, transform);
            pathObject.transform.position = currentPosition;
            var vector = buttonPositions[i + 1] - buttonPositions[i];
            var zRotate = MathF.Atan2(vector.y, vector.x) * Mathf.Rad2Deg;
            pathObject.transform.Rotate(0, 0, zRotate);
        }
        OnGenerated.Invoke();
    }
}