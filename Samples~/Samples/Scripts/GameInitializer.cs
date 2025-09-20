using UnityEngine;
using CharKole.GameService;

public class GameInitializer : ServiceInitializer
{
    protected override void RegisterServices()
    {
        base.RegisterServices();
        RegisterService<DataManager>();
    }
}
