using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

[RequireComponent(typeof(CircleCollider2D), typeof(SpriteRenderer))]
public class MapButton : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] private TextMeshPro text;
    [SerializeField] private UnityEvent OnClicked;
    private int index;
    public void SetValues(Sprite sprite, int index)
    {
        GetComponent<SpriteRenderer>().sprite = sprite;
        this.index = index;
        text.text = index.ToString();
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        LevelNameData level = new LevelNameData();
        level.SetName("GameScene");
        level.SetLevelIndex(index);
        OnClicked.Invoke();
    }
}
