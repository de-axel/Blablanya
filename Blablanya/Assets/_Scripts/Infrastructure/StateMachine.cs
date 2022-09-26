using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace _Scripts.Infrastructure
{
    public class StateMachine
    {
        private readonly Dictionary<IState, List<Transition>> _transitions;
        
        private List<Transition> _currentTransitions;
        private IState _currentState;

        public StateMachine()
        {
            _transitions = new Dictionary<IState, List<Transition>>();
        }

        public void AddTransition(IState from, IState to, Func<bool> condition)
        {
            if (!_transitions.ContainsKey(from))
                _transitions.Add(from, new List<Transition>());
            
            _transitions[from].Add(new Transition(to, condition));
        }

        public void SetState(IState state)
        {
            Debug.Log("set state");
            
            if (_currentState == state)
                return;
            
            _currentState?.Exit();
            _currentState = state;
            _currentTransitions = GetStateTransitions(_currentState);
            _currentState.Enter();
        }

        public void Update()
        {
            UpdateTransition();
        }

        private void UpdateTransition()
        {
            if (TryGetTransition(out Transition transition))
                SetState(transition.State);
        }

        private bool TryGetTransition(out Transition transition)
        {
            foreach (var currentTransition in _currentTransitions.Where(currentTransition => currentTransition.Condition()))
            {
                transition = currentTransition;
                return true;
            }

            transition = null;
            return false;
        }

        private List<Transition> GetStateTransitions(IState state) => 
            _transitions.ContainsKey(state) ? _transitions[state] : new List<Transition>();
    }
}