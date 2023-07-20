using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveSafeArea : MonoBehaviour
{
    [SerializeField] private Camera camera;
    private void Start()
    {
        SafeAreaData safeAreaData = new SafeAreaData();
        safeAreaData.SetMin(camera.ScreenToWorldPoint(Screen.safeArea.min));
        safeAreaData.SetMax(camera.ScreenToWorldPoint(Screen.safeArea.max));
    }
}
