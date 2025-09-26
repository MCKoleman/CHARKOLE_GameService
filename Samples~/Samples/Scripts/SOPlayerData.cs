using UnityEngine;

namespace CharKole.GameServices.Samples
{
    [CreateAssetMenu(fileName = "SOPlayerData", menuName = "CharKole/Samples/GameServices/SOPlayerData")]
    public class SOPlayerData : ScriptableObject
    {
        [SerializeField]
        private PlayerData playerData;

        public PlayerData GetPlayerData()
        {
            return playerData;
        }
    }
}
