using System;
using System.Collections.Generic;
using UnityEngine;

namespace CharKole.GameServices
{
    public static class ServiceLocator
    {
        private static Dictionary<Type, object> services = new();

        public static void Register<T>(T service)
        {
            Type type = typeof(T);
            if (services.ContainsKey(type))
            {
                Debug.LogWarning($"[CharKole.GameService.ServiceLocator]: Service {type} is already registered. Overwriting.");
            }
            services[type] = service;
        }

        public static T Get<T>()
        {
            Type type = typeof(T);
            if (services.TryGetValue(type, out object service))
            {
                return (T)service;
            }

            throw new Exception($"[CharKole.GameService.ServiceLocator]: Service of type {type} not found.");
        }

        public static void Clear()
        {
            services.Clear();
        }
    }
}
