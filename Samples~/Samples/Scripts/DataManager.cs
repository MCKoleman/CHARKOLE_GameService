using UnityEngine;
using CharKole.GameServices;

namespace CharKole.GameServices.Samples
{
    public class DataManager : GameService
    {
        [SerializeField]
        private SOPlayerData playerData;

        public override void Init()
        {
            base.Init();
        }

        public PlayerData GetPlayerData()
        {
            return playerData.GetPlayerData();
        }
    }
}
