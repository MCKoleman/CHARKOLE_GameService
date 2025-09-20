# CHARKOLE GameService

## Overview
The CHARKOLE GameService Unity package simplifies the workflow for initializing and using Singleton game managers.
By using services instead of multiple different Singletons, the order in which singletons are initialized can be defined manually

## Package Contents
- GameService.cs
  - Base class for your own services

- ServiceInitializer.cs
  - Base class for your own GameInitializer class. 

- ServiceLocator.cs
  - Static service locator. Does not need to be extended or modified to be used. 
  - The recommended pattern is making a GameServices.cs static class that assigns all services to static variables.

## Usage
- GameService
```cs
using CHARKOLE_GameService;
using UnityEngine;

public class MyCustomManager : GameService
{
    public override void Init()
    {
        // ... Include custom init logic here
    }

    // ... Implement your custom service
}
```

- ServiceInitializer
```cs
using CHARKOLE_GameService;
using UnityEngine;

public class GameInitializer : ServiceInitializer
{
    protected override void RegisterServices()
    {
        base.RegisterServices();
        RegisterService<MyCustomManager>();
        // ... Register your services in the necessary order here
    }
}
```

- ServiceLocator
```cs
using CHARKOLE_GameService;
using UnityEngine;

public static class GameServices
{
    public static MyCustomManager MyCustomManager = ServiceLocator.Get<MyCustomManager>();
    // ... List all of your services here
}
```

```cs
// No need to use CHARKOLE_GameService to use your own services
using UnityEngine;

public class MyCustomClass : MonoBehaviour
{
    private void Start()
    {
        // To access your custom services, just reference your static GameServices
        var value = GameServices.MyCustomManager.SomeFunctionCall();
    }
}
```