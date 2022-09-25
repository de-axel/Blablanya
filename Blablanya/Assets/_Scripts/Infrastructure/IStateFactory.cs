namespace _Scripts.Infrastructure
{
    public interface IStateFactory
    {
        public TState GetState<TState>() where TState : IState;
    }
}