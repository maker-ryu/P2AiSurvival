using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterContoller : BaseController
{
    public GameObject _gem;
    
    public override bool Init()
    {
        base.Init();
        
        Debug.Log("MonsterContoller에서 뭔가 초기화");

        return true;
    }

    // Start is called before the first frame update
    void Start()
    {
        _gem.SetActive(false);
        StartCoroutine(CoDropGem());
    }

    IEnumerator CoDropGem()
    {
        while (true)
        {
            _gem.SetActive(true);
            Debug.Log("젬 드롭 코루틴 시작");

            yield return new WaitForSeconds(3.0f);

            _gem.GetComponent<GemController>().Init();
                
            _gem.SetActive(false);
            Debug.Log("젬 드롭 코루틴 종료");
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
