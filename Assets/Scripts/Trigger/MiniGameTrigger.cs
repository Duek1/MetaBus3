using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 1.�÷��̾ Ư�� ������ ����
// 2.UI�� ���� �̴ϰ��� ���� ���� �ȳ�
// 3.���� �� �̴ϰ��� ������ ��ȯ
// 4.���� �÷��� �� ����
// 5.���� �Ǵ� ��� ����
// 6.���� ������ ����

public class MiniGameTrigger : MonoBehaviour
{
    public GameObject popupUI;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            popupUI.SetActive(true); // �����̽��ٸ� ���� �̴ϰ��� ����
        }
    
        if (other.CompareTag("Player"))
        {
            popupUI.SetActive(false);
        }
    }
}
