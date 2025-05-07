using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator animator;
    public float speed = 5f;
    private Rigidbody2D rb;

    public bool isJumpPressed = false; // 점프 키가 눌려 있는 상태를 저장

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        Vector2 move = new Vector2 (moveX, moveY).normalized;
        rb.velocity = move * speed;

        if (Input.GetKey (KeyCode.Space))
        {
            isJumpPressed = true;
        }

        if (isJumpPressed)
        {
            // 스페이스를 누르고 있는 동안 실행
            HandleJump();
        }

        void HandleJump()
        {
            // 점프 충전 , 부스트 , 착지 준비 등 처리
            Debug.Log("점프 처리 중..");
        }
    }

    private void LateUpdate()
    {
        // 캐릭터가 맵 밖으로 나가지 않게 제한
        Vector3 pos = transform.position;

        pos.x = Mathf.Clamp(pos.x, -8f, 8f); // X 경계
        pos.y = Mathf.Clamp(pos.y, -4.5f, 4.5f); // Y 경계

        transform.position = pos;
    }
}
