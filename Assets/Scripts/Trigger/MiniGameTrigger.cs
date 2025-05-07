using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 1.플레이어가 특정 구역에 진입
// 2.UI를 통해 미니게임 진입 여부 안내
// 3.진입 시 미니게임 씬으로 전환
// 4.게임 플레이 및 종료
// 5.점수 또는 결과 저장
// 6.원래 맵으로 복귀

public class MiniGameTrigger : MonoBehaviour
{
    public GameObject popupUI;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            popupUI.SetActive(true); // 스페이스바를 눌러 미니게임 시작
        }
    
        if (other.CompareTag("Player"))
        {
            popupUI.SetActive(false);
        }
    }
}
