﻿namespace _Scripts.Infrastructure
{
    public interface IState
    {
        public void Enter();
        public void Exit();
    }
}