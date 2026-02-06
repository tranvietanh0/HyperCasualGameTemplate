namespace HyperCasualGame.Scripts.Models
{
    using GameFoundationCore.Scripts.Models.Interfaces;

    public class UserLocalData : ILocalData
    {
        public int Score { get; set; } = 0;
        public void Init()
        {

        }
    }
}