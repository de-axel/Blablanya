using UnityEngine;
using Zenject;

namespace _Scripts.Infrastructure
{
    public class Bootstrapper : MonoBehaviour
    {
        private ProjectStateMachine _stateMachine;

        [Inject]
        public void Construct(ProjectStateMachine projectStateMachine)
        {
            _stateMachine = projectStateMachine;
            Debug.Log("start game init");
        }

        private void Awake()
        {
            //DontDestroyOnLoad(this);
        }
    }
}
