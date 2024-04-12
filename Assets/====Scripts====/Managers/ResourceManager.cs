using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class ResourceManager
{
    public void LoadPrefab()
    {
        Addressables.LoadAssetAsync<GameObject>("Preload").Completed +=
            (handle =>
            {
                GameObject go = GameObject.Instantiate(handle.Result);

            });

    }

    public void LoadAllAsync()
    {
        var something = Addressables.LoadResourceLocationsAsync("Preload");

        something.Completed += handle =>
        {
            var some = handle.Result;

            foreach (var lo in some)
            {
                Debug.Log($"lo.PrimaryKey : {lo.PrimaryKey}");
                Debug.Log($"lo.ResourceType : {lo.ResourceType}");

                Addressables.LoadAssetAsync<Object>(lo.PrimaryKey).Completed +=
                    (operationHandle =>
                    {
                        Object go = Object.Instantiate(operationHandle.Result);
                    });
            }
        };
    }
}
