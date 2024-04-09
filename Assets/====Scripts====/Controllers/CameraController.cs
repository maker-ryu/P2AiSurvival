using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform _target;
    private bool _targetIsNull = false;
    
    // Start is called before the first frame update
    void Start()
    {
        if (_target == null)
            _targetIsNull = true;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(_targetIsNull)
            return;

        transform.position = new Vector3(_target.position.x, _target.position.y, -10);
    }
}
