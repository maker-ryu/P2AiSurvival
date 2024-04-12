using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager
{
    private Vector3 _moveDir;

    public event Action<Vector3> OnMoveDirChanged;  
    public Vector3 MoveDir
    {
        get { return _moveDir; }
        set
        {
            _moveDir = value;
            OnMoveDirChanged?.Invoke(_moveDir);
        }
    }
    
    public void CallTest()
    {
        Debug.Log("GameManager에서 Test함수 호출");
    }
}
