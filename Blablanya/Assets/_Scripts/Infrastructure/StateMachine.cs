using System;
using System.Collections.Generic;
using UnityEngine;

namespace _Scripts.Infrastructure
{
    public class StateMachine
    {
        private Dictionary<Type, IState> _states;
        private Dictionary<Type, List<Transition>> _transitions;
        private IState _currentState;

        public StateMachine()
        {
            _states = new Dictionary<Type, IState>();
            _transitions = new Dictionary<Type, List<Transition>>();
        }

        /*public void Enter<TState>() where TState : IState
        {
            _currentState?.Exit();
        }*/

        public void AddTransition(IState from, IState to, Func<bool> condition)
        {
            Type state = from.GetType();

            if (!_transitions.ContainsKey(state))
            {
                _transitions.Add(state, new List<Transition>());
            }
            
            _transitions[state].Add(new Transition(to, condition));
        }

        public void TryGetTransition()
        {
            
        }

        public void SetState(IState state)
        {
            Debug.Log("set state");
            
            if (_currentState == state)
                return;
            
            _currentState?.Exit();
            _currentState = state;
            _currentState.Enter();
        }
    }
}