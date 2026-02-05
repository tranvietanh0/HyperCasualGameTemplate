namespace HyperCasualGame.Scripts.Scenes
{
    using GameFoundationCore.Scripts;
    using VContainer;
    using VContainer.Unity;

    public class GameLifetimeScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterGameFoundation(this.transform);
        }
    }
}