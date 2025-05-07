using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputHandler : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;

    public bool isJumpPressed = false; // ���� Ű�� ���� �ִ� ���¸� ����

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // GetKeyDown -> ���� �õ�
    // GetKeyUp -> ���� ���� ���� �� �߰� ���
    private void Update()
    {
        float axisX = Input.GetAxis("Horizontal"); // �ε巴�� ����
        float rawY = Input.GetAxisRaw("Horizontal"); // ��� -1,0,1

        Debug.Log($"Axis : {axisX}, Raw : {rawY}");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            isJumpPressed = true; // �����̽��� ������ �� true
            Debug.Log("���� Ű ����");
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            isJumpPressed = false; // �����̽��� ���� �� flase
            Debug.Log("���� Ű ����");
        }

        if (isJumpPressed)
        {
            // �����̽��� ������ �ִ� ���� ����
            HandleJump();
        }

        if (Input.GetMouseButtonDown(0)) // ���� Ŭ��
        {
            Debug.Log("���� Ŭ�� �߻�");
        }

        if (Input.GetMouseButtonUp(1)) // ������ Ŭ��
        {
            Debug.Log("������ Ŭ�� �߻�");
        }

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 screenPos = Input.mousePosition;
            screenPos.z = 10f;
            // ī�޶�κ����� �Ÿ� (Orthoraphic �̸� ���� ����)

            Vector3 worldPos = Camera.main.ScreenToWorldPoint(screenPos);
            Debug.Log($"ȭ�� ��ǥ: {screenPos} , ���� ��ǥ : {worldPos}");
        }
    }



    void HandleJump()
    {
        // ���� ���� , �ν�Ʈ , ���� �غ� �� ó��
        Debug.Log("���� ó�� ��..");
    }

}
