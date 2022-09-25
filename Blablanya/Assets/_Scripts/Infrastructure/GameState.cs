namespace _Scripts.Infrastructure
{
    public class GameState : IState
    {
        private SceneLoader _sceneLoader;

        public GameState(SceneLoader sceneLoader)
        {
            _sceneLoader = sceneLoader;
        }
        
        public void Enter()
        {
            
        }

        public void Exit()
        {
            
        }
    }
}