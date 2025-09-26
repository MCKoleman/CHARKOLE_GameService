using CHARKOLE_GameService;
using UnityEngine;

namespace CharKole.GameService.Samples
{
    public class GameInitializer : ServiceInitializer
    {
        protected override void RegisterServices()
        {
            base.RegisterServices();
            RegisterService<DataManager>();
        }
    }
}
