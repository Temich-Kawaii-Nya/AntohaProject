using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenePath : MonoBehaviour
{
    [SerializeField] List<Transform> path = new List<Transform>();
    private void Awake()
    {
        Destroy(gameObject);
    }
    public void AddPoint(Transform point)
    {
        path.Add(point);
    }
    public List<Vector2> GetPathPoint()
    {
        List<Vector2> points = new List<Vector2>();
        foreach (var item in path)
        {
            points.Add(item.position);
        }
        return points;
    } 
}
