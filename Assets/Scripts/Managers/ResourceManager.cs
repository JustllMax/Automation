using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    public static ResourceManager Instance { get; private set; }

    float magazineCap = 1000;
    [SerializeField]
    float energyMagazine = 0;
    [SerializeField]
    float metalMagazine = 0;
    [SerializeField]
    float energyModifier = 0;
    [SerializeField]
    float metalModifier = 0;
    [SerializeField]
    float resourceActivationTime = 5f;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        StartCoroutine(IncreaseResourceAmount());
    }

    public void ChangeModifier(ResourceType type, float amount)
    {
        
        switch (type)
        {
            case ResourceType.Energy:
                energyModifier += amount;

                break;

            case ResourceType.Metal:
                metalModifier += amount;

                break;
        }
    }


    IEnumerator IncreaseResourceAmount()
    {
        yield return new WaitForSeconds(resourceActivationTime);

        energyMagazine += energyModifier;
        if(energyMagazine > magazineCap)
            energyMagazine = magazineCap;


        metalMagazine += metalModifier;
        if(metalMagazine > magazineCap)
            metalMagazine = magazineCap;


        StartCoroutine(IncreaseResourceAmount());

        yield return null;


    }
}
