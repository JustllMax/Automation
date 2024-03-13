using System.Collections;
using System.Collections.Generic;
using Unity.Jobs;
using Unity.Collections;
using UnityEngine;

public class TestBuilding : MonoBehaviour
{

    ResourceType resourceType;
    int level = 1;
    float resourceAmount;
    [SerializeField] bool shouldUpgrade;

    void Start()
    {
        ResourceManager.Instance.ChangeModifier(resourceType, resourceAmount);
        if(shouldUpgrade)
            Upgrade();
    }

    public void Upgrade()
    {
        ResourceManager.Instance.ChangeModifier(resourceType, -resourceAmount);
        resourceAmount *= level;
        ResourceManager.Instance.ChangeModifier(resourceType, resourceAmount);

    }
    public void OnBuildingDestroy()
    {
        ResourceManager.Instance.ChangeModifier(resourceType, -resourceAmount);

        Destroy(gameObject);
    }

}
