using Zenject;

namespace _Scripts.Infrastructure
{
    public class StateFactory : IStateFactory
    {
        private DiContainer _diContainer;

        public StateFactory(DiContainer diContainer)
        {
            _diContainer = diContainer;
        }

        public TState GetState<TState>() where TState : IState
        {
            return _diContainer.Instantiate<TState>();
        }
    }
}