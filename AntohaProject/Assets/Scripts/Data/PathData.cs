using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Path", menuName = "GameSO/Path")]
public class PathData : ScriptableObject
{
    public List<Vector2> points = new List<Vector2>();
#if UNITY_EDITOR
    [ContextMenu("Save path")]
    private void SavePoints()
    {
        var enemyPath = FindObjectOfType<ScenePath>();
        if (enemyPath != null)
        {
            points = enemyPath.GetPathPoint();
            UnityEditor.EditorUtility.SetDirty(this);
            UnityEditor.SceneManagement.EditorSceneManager.MarkSceneDirty(UnityEngine.SceneManagement.SceneManager.GetActiveScene());
        }
    }
    [ContextMenu("Load points")]
    private void LoadPoints()
    {
        GameObject path = new GameObject("Path");
        ScenePath scenePath = path.AddComponent<ScenePath>();
        for (int i = 0; i < points.Count; i++)
        {
            GameObject point = new GameObject($"Point{i}");
            point.transform.SetParent(path.transform);
            point.transform.position = points[i];
            scenePath.AddPoint(point.transform);
        }
    }
#endif
}
