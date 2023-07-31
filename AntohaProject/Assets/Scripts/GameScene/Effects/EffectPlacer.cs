using UnityEngine;

[RequireComponent(typeof(EffectGenerator))]
public class EffectPlacer : MonoBehaviour
{
    private EffectGenerator generator;
    private void Awake()
    {
        generator = GetComponent<EffectGenerator>();
    }
    private void OnEnable()
    {
        DestroyEffect.OnEffectActivated += SetDestroyEffect;
    }
    private void OnDisable()
    {
        DestroyEffect.OnEffectActivated -= SetDestroyEffect;
    }
    private void SetDestroyEffect(Transform obj)
    {
        var effect = generator.GetEffect();
        effect.SetActive(true);
        effect.transform.position = obj.position;
    }
}
