using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputHandler : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;

    public bool isJumpPressed = false; // 점프 키가 눌려 있는 상태를 저장

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // GetKeyDown -> 점프 시도
    // GetKeyUp -> 점프 충전 해제 등 추가 기능
    private void Update()
    {
        float axisX = Input.GetAxis("Horizontal"); // 부드럽게 변함
        float rawY = Input.GetAxisRaw("Horizontal"); // 즉시 -1,0,1

        Debug.Log($"Axis : {axisX}, Raw : {rawY}");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            isJumpPressed = true; // 스페이스를 눌렀을 때 true
            Debug.Log("점프 키 눌림");
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            isJumpPressed = false; // 스페이스를 땠을 때 flase
            Debug.Log("점프 키 해제");
        }

        if (isJumpPressed)
        {
            // 스페이스를 누르고 있는 동안 실행
            HandleJump();
        }

        if (Input.GetMouseButtonDown(0)) // 왼쪽 클릭
        {
            Debug.Log("왼쪽 클릭 발생");
        }

        if (Input.GetMouseButtonUp(1)) // 오른쪽 클릭
        {
            Debug.Log("오른쪽 클릭 발생");
        }

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 screenPos = Input.mousePosition;
            screenPos.z = 10f;
            // 카메라로부터의 거리 (Orthoraphic 이면 생략 가능)

            Vector3 worldPos = Camera.main.ScreenToWorldPoint(screenPos);
            Debug.Log($"화면 좌표: {screenPos} , 월드 좌표 : {worldPos}");
        }
    }



    void HandleJump()
    {
        // 점프 충전 , 부스트 , 착지 준비 등 처리
        Debug.Log("점프 처리 중..");
    }

}
