using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : BaseController
{
    private float _speed = 3.0f;
    private Vector3 _moveDir;
    
    // public Vector3 MoveDir
    // {
    //     get { return _moveDir; }
    //     set { _moveDir = value; }
    // }
    
    public override bool Init()
    { 
        base.Init();
        
        // Debug.Log("PlayerController에서 뭔가 초기화");

        return true;
    }

    // Start is called before the first frame update
    void Start()
    {
        Managers.Game.OnMoveDirChanged += HandleOnPlayerMoveChanged;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += _moveDir * _speed * Time.deltaTime;
    }

    void HandleOnPlayerMoveChanged(Vector3 moveDir)
    {
        _moveDir = moveDir;
        // transform.position += _moveDir * _speed * Time.deltaTime;
    }

    
}
