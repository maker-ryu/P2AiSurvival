using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : BaseController
{
    private float _speed = 3.0f;
    private Vector3 _moveDir = new Vector3();
    
    public Vector3 MoveDir
    {
        get { return _moveDir; }
        set { _moveDir = value; }
    }
    
    public override bool Init()
    { 
        base.Init();
        
        Debug.Log("PlayerController에서 뭔가 초기화");

        return true;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Vector2 moveDir = Vector2.zero;
        //
        // if (Input.GetKey(KeyCode.W))
        //     moveDir.y += 1;
        // if (Input.GetKey(KeyCode.S))
        //     moveDir.y -= 1;
        // if (Input.GetKey(KeyCode.D))
        //     moveDir.x += 1;
        // if (Input.GetKey(KeyCode.A))
        //     moveDir.x -= 1;
        //
        // moveDir = moveDir.normalized;
        //
        // _moveDir = new Vector3(moveDir.x, moveDir.y);

        transform.position += _moveDir * _speed * Time.deltaTime;
    }

    
}
