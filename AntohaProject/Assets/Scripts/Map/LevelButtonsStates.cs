using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelButtonsStates
{
    public List<LevelState> States = new List<LevelState>();
}
public enum LevelState
{
    Locked,
    Open,
    OneStar,
    TwoStars,
    ThreeStars
}
