using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class BoarderSize : MonoBehaviour
{ 
    private const float FullSize = 2f;
    private void Start()
    {
        SetSize();
    }
    private void SetSize()
    {
        float yScale = new SafeAreaData().GetMax().y * FullSize;
        BoxCollider2D boxCollider2D = GetComponent<BoxCollider2D>();
        boxCollider2D.size = new Vector2(boxCollider2D.size.x, yScale);
    }
}
