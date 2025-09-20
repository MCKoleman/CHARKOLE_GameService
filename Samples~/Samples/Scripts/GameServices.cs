using UnityEngine;
using CharKole.GameService;

public static class GameServices
{
    public static DataManager DataManager = ServiceLocator.Get<DataManager>();
}
