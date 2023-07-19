using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private string savedSceneName;
    private readonly LevelNameData levelName = new LevelNameData();
    private void Start()
    {
        if (!string.IsNullOrEmpty(savedSceneName))
        {
            StartCoroutine(AddScene(savedSceneName));
        }
    }
    public void Load(int level)
    {
        if (!string.IsNullOrEmpty(levelName.GetName()))
        {
            StartCoroutine(SceneController(levelName.GetName()));
        }
    }

    private IEnumerator SceneController(string name)
    {
        if (!string.IsNullOrEmpty(savedSceneName))
        {
            yield return StartCoroutine(RemoveOldScene());
            yield return StartCoroutine(UnloadResourses());
        }
        yield return StartCoroutine(AddScene(name));
    }
    private IEnumerator AddScene(string name)
    {
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(name, LoadSceneMode.Additive);
        while (!asyncOperation.isDone)
        {
            yield return null;
        }
        savedSceneName = name;
        SceneManager.SetActiveScene(SceneManager.GetSceneByName(name)); 
    }
    private IEnumerator RemoveOldScene()
    {
        AsyncOperation asyncOperation = SceneManager.UnloadSceneAsync(savedSceneName);
        while (!asyncOperation.isDone)
        {
            yield return null;
        }
    }
    private IEnumerator UnloadResourses()
    {
        AsyncOperation asyncOperation = Resources.UnloadUnusedAssets();
        while (!asyncOperation.isDone)
        {
            yield return null;
        }
    }
}
