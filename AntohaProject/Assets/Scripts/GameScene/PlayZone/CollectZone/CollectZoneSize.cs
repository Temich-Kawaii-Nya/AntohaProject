using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class CollectZoneSize : MonoBehaviour
{
    [SerializeField] private BoxCollider2D collider;
    private const float offset = 1f;

    private void Awake()
    {
        SetSize();
    }
    private void SetSize()
    {
        float tempX = new SafeAreaData().GetMax().x * 2;
        float tempY = new SafeAreaData().GetMax().y * 3 /4 + offset;
        collider.size = new Vector2(tempX, tempY);
        collider.offset = new Vector2(collider.offset.x, new SafeAreaData().GetMax().y / 2f + 1 * 3 / 4f);
    }
}
