using UnityEngine;
using CharKole.GameServices;

namespace CharKole.GameServices.Samples
{
    public static class Services
    {
        public static DataManager DataManager = ServiceLocator.Get<DataManager>();
    }
}
