using CHARKOLE_GameService;
using UnityEngine;

namespace CharKole.GameService.Samples
{
    public static class GameServices
    {
        public static DataManager DataManager = ServiceLocator.Get<DataManager>();
    }
}
