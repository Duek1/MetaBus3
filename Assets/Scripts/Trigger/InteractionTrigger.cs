using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ��ü ���� �帧 
// 1.Tilemap�̳� ������Ʈ�� �̿��� �� ����
// 2. Ư�� ������ ��ȣ�ۿ� ������ Collider2D + IsTrigger ������Ʈ ��ġ
// 3. Player�� �ش� ������ �����ϸ� OnTriggerEnter2D()�� ����
// 4. �ʿ��� UI�� ǥ���ϰų� �̺�Ʈ�� ����
// 5. �������� ��� ��� OnTriggerExit2D()�� ���� ó��
public class InteractionTrigger : MonoBehaviour
{
    public GameObject interactionPopup; // ��ȣ�ۿ� �ȳ� UI (�����Ϳ��� ����)

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            interactionPopup.SetActive(true); // �÷��̾ �����ϸ� �˾� ǥ��
        }
    
        if (other.CompareTag("Player"))
        {
            interactionPopup.SetActive(false); // �÷��̾ ����� �˾� ����
        }

    }
    // �÷��̾ Ʈ���ſ� ������ �� ����Ǵ� �Լ�
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Ʈ���ſ� ���� ������Ʈ�� "Player" �±׸� ������ �ִ��� Ȯ��
        if (other.CompareTag("Player"))
        {
            Debug.Log("��ȣ�ۿ� ������ ������ �����߽��ϴ�.");

            // ���ϴ� �̺�Ʈ ����
        }
    }
}
