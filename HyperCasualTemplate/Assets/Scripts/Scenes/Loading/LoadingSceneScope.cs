namespace HyperCasualGame.Scripts.Scenes.Loading
{
    using UnityEngine;
    using VContainer;
    using VContainer.Unity;

    public class LoadingSceneScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            base.Configure(builder);
            Debug.Log("[LoadingSceneScope] Loading scene scope");
        }
    }
}