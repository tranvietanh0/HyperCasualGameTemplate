namespace HyperCasualGame.Scripts.Test
{
    using System;
    using GameFoundationCore.Scripts.DI;
    using HyperCasualGame.Scripts.Models;
    using UnityEngine;

    public class Test : MonoBehaviour
    {
        public  bool          Check = false;
        private UserLocalData userLocalData;
        private void Start()
        {
            var container = this.GetCurrentContainer();
            this.userLocalData = container.Resolve<UserLocalData>();
        }

        private void Update()
        {
            if (this.Check)
            {
                Debug.Log("User Level: " + this.userLocalData.Score);
                this.userLocalData.Score++;
                Debug.Log("User Level: " + this.userLocalData.Score);
                this.Check = false;
            }
        }
    }
}