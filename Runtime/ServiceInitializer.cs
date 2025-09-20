using System;
using System.Collections.Generic;
using UnityEngine;

namespace CharKole.GameService
{
    public class ServiceInitializer : MonoBehaviour
    {
        private Dictionary<Type, GameService> services = new();

        public static ServiceInitializer Instance { get; private set; }

        private void Awake()
        {
            if (Instance != null)
            {
                Destroy(this.gameObject);
                return;
            }

            Instance = this;
            DontDestroyOnLoad(this.gameObject);

            RegisterServices();
            InitServices();
        }

        // Override this method in your implementation to register services in the desired order
        protected virtual void RegisterServices() { }

        // Use this method to register the GameServices that are children of this object
        protected void RegisterService<T>() where T : GameService
        {
            T service = this.GetComponentInChildren<T>();
            if (service == null)
            {
                Debug.LogError($"[CHARKOLE_GameService.ServiceInitializer]: Service {typeof(T)} does not exist on ServiceInitializer.");
                return;
            }

            if (services.ContainsKey(service.GetType())) 
            {
                Debug.LogWarning($"[CHARKOLE_GameService.ServiceInitializer]: Skipped registering service {service.name}, a service of the same type already exists.");
                return;
            }

            Debug.Log($"[CHARKOLE_GameService.ServiceInitializer]: Registering service {service.name}.");
            ServiceLocator.Register<T>(service);
            services.Add(service.GetType(), service);
        }

        private void InitServices()
        {
            foreach (GameService service in services.Values)
            {
                Debug.Log($"[CHARKOLE_GameService.ServiceInitializer]: Initializing service {service.name}.");
                service.Init();
            }
        }
    }
}
