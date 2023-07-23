using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class EnemiesMovement : MonoBehaviour
{
    private float speed = 5f;
    [SerializeField] private PathData path;
    private int index;
    private Rigidbody2D rigidbody;
    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
    public void SetPath(PathData pathData)
    {
        path = pathData;
    }
    private void FixedUpdate()
    {
        rigidbody.MovePosition(Vector3.MoveTowards(transform.position, path.points[index], speed * Time.fixedDeltaTime));
        if (Vector2.Distance(transform.position, path.points[index]) < 0.01f)
        {
            if (index < path.points.Count - 1)
            {
                index++;
            }
            else
                Destroy(gameObject);
        }
    }
}
