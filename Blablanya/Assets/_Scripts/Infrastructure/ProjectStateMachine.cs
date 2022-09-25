using UnityEngine;

namespace _Scripts.Infrastructure
{
    public class ProjectStateMachine : StateMachine
    {
        private readonly IStateFactory _stateFactory;
        
        public ProjectStateMachine(IStateFactory stateFactory)
        {
            _stateFactory = stateFactory;

            BootState bootState = _stateFactory.GetState<BootState>();
            GameState gameState = _stateFactory.GetState<GameState>();
            
            AddTransition(bootState, gameState, () => bootState.IsGameLoaded);
            Debug.Log("run project state machine");
            SetState(bootState);
        }
    }
}