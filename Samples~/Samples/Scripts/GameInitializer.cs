using UnityEngine;
using CharKole.GameServices;

namespace CharKole.GameServices.Samples
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
