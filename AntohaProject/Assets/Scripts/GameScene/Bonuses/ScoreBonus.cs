using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBonus : BaseBonus
{
    [SerializeField] private ScoreObject scoreObject;
    private int baseScore;
    private int score;
    private float temp;
    private void Awake()
    {
        baseScore = scoreObject.GetScore;
    }
    protected override void Activate(GameObject player)
    {
        float offset = 5f;
        float fullDistance = new SafeAreaData().GetMax().y - offset - new SafeAreaData().GetMin().y;
        float distanceDiff = (new SafeAreaData().GetMax().y - offset - transform.position.y);
        if (distanceDiff <= 0)
            temp = 1;
        else
            temp = 1 - (distanceDiff / fullDistance);
        Debug.Log(temp);
        score = Mathf.RoundToInt(Mathf.Lerp(baseScore / 2, baseScore, temp));
        Debug.Log(score);
        scoreObject.Activate(score);
    }
}
