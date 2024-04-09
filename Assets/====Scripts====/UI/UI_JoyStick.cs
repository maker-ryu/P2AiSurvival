using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UI_JoyStick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    [SerializeField] private Image _handleBG;
    [SerializeField] private Image _handler;
    
    Vector2 _firstClick = Vector3.zero;
    Vector3 _moveDir = Vector3.zero;
    
    // TEMP
    public GameObject _player;

    private float maxHandlerDistance;
    
    // Start is called before the first frame update
    void Start()
    {
        maxHandlerDistance = _handleBG.rectTransform.sizeDelta.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 화면에 클릭이 된 순간
    public void OnPointerDown(PointerEventData eventData)
    {
        _firstClick = eventData.position;
        _handleBG.transform.position = _firstClick;
        _handler.transform.position = _firstClick;
    }
    
    // 화면에 손이 떨어진 순간
    public void OnPointerUp(PointerEventData eventData)
    {
        _handler.transform.position = _firstClick;

        // 움직임 정지
        _moveDir = Vector3.zero;
        
        // TEMP
        _player.GetComponent<PlayerController>().MoveDir = _moveDir;
    }

    // 드래그 되는 중
    public void OnDrag(PointerEventData eventData)
    {
        // 핸들이 원 바깥으로 나가지 않도록
        Vector2 distance = eventData.position - _firstClick;
        if (distance.magnitude >= maxHandlerDistance)
            _handler.transform.position = _firstClick + distance.normalized * maxHandlerDistance;
        else
            _handler.transform.position = _firstClick + distance;
        
        // 플레이어가 움직일 방향을 저장
        _moveDir = distance.normalized;
        
        // TEMP
        _player.GetComponent<PlayerController>().MoveDir = _moveDir;

        
        // _handler.transform.position = eventData.position;
        
        
        // Debug.Log($"evenData : {eventData.position}");
        Debug.Log($"moveDir : {_moveDir}");
        
    }
}
