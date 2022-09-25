using _Scripts.Infrastructure;
using Zenject;

namespace _Scripts.ZenjectInstallers
{
    public class GameStateInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<ProjectStateMachine>().FromNew().AsSingle();
            Container.Bind<IStateFactory>().To<StateFactory>().AsSingle();
            Container.Bind<SceneLoader>().FromNew().AsSingle();
        }
    }
}
