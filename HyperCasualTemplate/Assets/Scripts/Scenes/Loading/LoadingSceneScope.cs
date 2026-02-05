namespace HyperCasualGame.Scripts.Scenes.Loading
{
    using GameFoundationCore.Scripts.DI.VContainer;
    using UnityEngine;
    using VContainer;
    using VContainer.Unity;

    public class LoadingSceneScope : SceneScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            base.Configure(builder);
        }
    }
}