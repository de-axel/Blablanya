using System;

namespace _Scripts.Infrastructure
{
    public class Transition
    {
        public IState State { get; }
        public Func<bool> Condition { get; }

        public Transition(IState state, Func<bool> condition)
        {
            State = state;
            Condition = condition;
        }
    }
}