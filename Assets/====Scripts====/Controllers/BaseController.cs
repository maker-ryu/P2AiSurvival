using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class BaseController : MonoBehaviour
{
    private void Awake()
    {
        Init();
    }

    public virtual bool Init()
    {
        // Debug.Log("BaseController에서 뭔가 초기화");
        return true;
    }
}
