using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemController : BaseController
{
    public override bool Init()
    {
        base.Init();

        Debug.Log("GemController에서 뭔가 초기화");
        
        return true;
    }
}
