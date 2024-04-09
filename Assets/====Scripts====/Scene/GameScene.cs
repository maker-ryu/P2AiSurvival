using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScene : MonoBehaviour
{
    public GameObject _snakePrefab;
    public GameObject _slimePrefab;
    public GameObject _goblinPrefab;
    public GameObject _mapPrefab;

    private GameObject _snake;
    private GameObject _slime;
    private GameObject _goblin;
    private GameObject _map;
    
    // Start is called before the first frame update
    void Start()
    {
        _snake = GameObject.Instantiate(_snakePrefab);
        _slime = GameObject.Instantiate(_slimePrefab);
        _goblin = GameObject.Instantiate(_goblinPrefab);
        
        _map = GameObject.Instantiate(_mapPrefab);

        GameObject _monsters = new GameObject();
        _monsters.name = "Monsters";
        
        _snake.transform.SetParent(_monsters.transform);
        _slime.transform.SetParent(_monsters.transform);
        _goblin.transform.SetParent(_monsters.transform);
        
        // _slime.AddComponent<PlayerController>();
        
        // Managers.Instance.CallTest();
        Managers.Game.CallTest();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
