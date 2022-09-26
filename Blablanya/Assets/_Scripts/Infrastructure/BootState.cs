using UnityEngine;

namespace _Scripts.Infrastructure
{
    public class BootState : IState
    {
        private readonly SceneLoader _sceneLoader;
        
        public bool IsGameLoaded { get; private set; }

        public BootState(SceneLoader sceneLoader)
        {
            _sceneLoader = sceneLoader;
        }
        
        public void Enter()
        {
            _sceneLoader.LoadScene(SceneNames.Game, () => IsGameLoaded = true);
            Debug.Log("blablanya");
        }

        public void Exit()
        {
        
        }
    }
}