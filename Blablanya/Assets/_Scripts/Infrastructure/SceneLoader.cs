using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace _Scripts.Infrastructure
{
    public class SceneLoader
    {
        public void LoadScene(string sceneName, Action onCompleted)
        {
            AsyncOperation sceneLoad = SceneManager.LoadSceneAsync(sceneName);
            sceneLoad.completed += operation =>
            {
                onCompleted?.Invoke();
            };
        }

        public void UnloadScene()
        {
            
        }
    }
}