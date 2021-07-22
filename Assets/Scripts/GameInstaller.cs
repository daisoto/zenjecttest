using Zenject;

public class GameInstaller : MonoInstaller<GameInstaller>
{
    public override void InstallBindings()
    {
        InstallGameManager();
        InstallMisc();
    }

    private void InstallGameManager()
    {
        Container.Bind<GameStateFactory>().AsSingle();

        Container.BindInterfacesAndSelfTo<MenuState>().AsSingle();
        Container.BindInterfacesAndSelfTo<GameplayState>().AsSingle();
        Container.BindInterfacesAndSelfTo<GameOverState>().AsSingle();
        Container.BindInterfacesAndSelfTo<VictoryState>().AsSingle();

        Container.BindFactory<MenuState, MenuState.Factory>().WhenInjectedInto<GameStateFactory>();
        Container.BindFactory<GameplayState, GameplayState.Factory>().WhenInjectedInto<GameStateFactory>();
        Container.BindFactory<GameOverState, GameOverState.Factory>().WhenInjectedInto<GameStateFactory>();
        Container.BindFactory<VictoryState, VictoryState.Factory>().WhenInjectedInto<GameStateFactory>();
    }

    private void InstallMisc()
    {
        Container.Bind<AsyncProcessor>().FromNewComponentOnNewGameObject().AsSingle();
    }
}