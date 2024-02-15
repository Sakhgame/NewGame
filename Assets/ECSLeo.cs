using Leopotam.Ecs;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Voody.UniLeo;

public class ECSLeo : MonoBehaviour
{
    private EcsWorld world;
    private EcsSystems systems;

    private void Start()
    {
        world = new EcsWorld();
        systems = new EcsSystems(world);

        systems.ConvertScene();

        AddInjections();
        AddOneFrames();
        AddSystem();


        systems.Init();
    }

    private void AddInjections()
    {

    }

    private void AddSystem()
    {
        
    }

    private void AddOneFrames()
    {

    }


    private void Update()
    {
        systems.Run();
    }

    private void OnDestroy()
    {
        if (systems == null) return;
        systems.Destroy();
        systems=null;
        world.Destroy();
        world = null;

    }
}
