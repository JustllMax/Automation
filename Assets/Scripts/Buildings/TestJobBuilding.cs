using System.Collections;
using System.Collections.Generic;
using Unity.Burst;
using Unity.Jobs;
using UnityEngine;

[BurstCompile]
public struct TestJobBuilding : IJob
{

    public float _amountOfResource;
    ResourceType _resourceType;

    public TestJobBuilding( float amountOfResource, ResourceType resourceType)
    {
        _amountOfResource = amountOfResource;
        _resourceType = resourceType;
    }
    public void Execute()
    {

    }


}
