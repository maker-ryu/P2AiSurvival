using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameScene : MonoBehaviour
{
    public GameObject _snakePrefab;
    public GameObject _slimePrefab;
    public GameObject _goblinPrefab;
    public GameObject _mapPrefab;

    private GameObject _snake;
    private GameObject _player;
    private GameObject _goblin;
    private GameObject _map;
    
    // Start is called before the first frame update
    void Start()
    {
        // StartSet();
        // Managers.Object.Spawn();
        // Managers.Resource.LoadPrefab();
        Managers.Resource.LoadAllAsync();
    }
    

    void StartSet()
    {
        _snake = GameObject.Instantiate(_snakePrefab);
        _player = GameObject.Instantiate(_slimePrefab);
        _goblin = GameObject.Instantiate(_goblinPrefab);
        
        _map = GameObject.Instantiate(_mapPrefab);

        GameObject _monsters = new GameObject();
        _monsters.name = "Monsters";
        
        _snake.transform.SetParent(_monsters.transform);
        _player.transform.SetParent(_monsters.transform);
        _goblin.transform.SetParent(_monsters.transform);
        
        _player.AddComponent<PlayerController>();

        Camera.main.AddComponent<CameraController>()._target = _player.transform;
        
        // Managers.Instance.CallTest();
        Managers.Game.CallTest();
    }
    
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
