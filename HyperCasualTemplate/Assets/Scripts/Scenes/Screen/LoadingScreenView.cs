namespace HyperCasualGame.Scripts.Scenes.Screen
{
    using Cysharp.Threading.Tasks;
    using GameFoundationCore.Scripts.Signals;
    using GameFoundationCore.Scripts.UIModule.ScreenFlow.BaseScreen.Presenter;
    using GameFoundationCore.Scripts.UIModule.ScreenFlow.BaseScreen.View;
    using UITemplate.Scripts.UserData;
    using UniT.Logging;
    using UnityEngine;

    public class LoadingScreenView : BaseView
    {
    }


    [ScreenInfo(nameof(LoadingScreenView))]
    public class LoadingScreenPresenter : BaseScreenPresenter<LoadingScreenView>
    {
        private readonly UserDataManager userDataManager;

        public LoadingScreenPresenter(
            SignalBus      signalBus,
            ILoggerManager loggerManager,
            UserDataManager userDataManager
        ) : base(signalBus, loggerManager)
        {
            this.userDataManager = userDataManager;
        }

        public async override UniTask BindData()
        {
            Debug.Log("LoadingScreenPresenter - BindData");
            await this.userDataManager.LoadUserData();
        }
    }
}