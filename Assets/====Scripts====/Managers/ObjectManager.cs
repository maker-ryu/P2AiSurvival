using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class ObjectManager
{
    public PlayerController Player { get; }
    public HashSet<MonsterContoller> Monsters { get; } = new HashSet<MonsterContoller>();

    private GameObject go;
    
    public void Spawn()
    {
        Addressables.LoadAssetAsync<GameObject>("Player.prefab").Completed +=
            (handle =>
            {
                go = GameObject.Instantiate(handle.Result);

            });

    }
    // AsyncOperationHandle
}

