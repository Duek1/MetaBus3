using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator animator;
    public float speed = 5f;
    private Rigidbody2D rb;

    public bool isJumpPressed = false; // ���� Ű�� ���� �ִ� ���¸� ����

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
            // �����̽��� ������ �ִ� ���� ����
            HandleJump();
        }

        void HandleJump()
        {
            // ���� ���� , �ν�Ʈ , ���� �غ� �� ó��
            Debug.Log("���� ó�� ��..");
        }
    }

    private void LateUpdate()
    {
        // ĳ���Ͱ� �� ������ ������ �ʰ� ����
        Vector3 pos = transform.position;

        pos.x = Mathf.Clamp(pos.x, -8f, 8f); // X ���
        pos.y = Mathf.Clamp(pos.y, -4.5f, 4.5f); // Y ���

        transform.position = pos;
    }
}
