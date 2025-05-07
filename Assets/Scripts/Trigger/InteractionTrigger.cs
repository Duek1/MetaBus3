using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 전체 동작 흐름 
// 1.Tilemap이나 으보젝트를 이용해 맵 구성
// 2. 특정 영역에 상호작용 가능한 Collider2D + IsTrigger 오브젝트 배치
// 3. Player가 해당 영역에 진입하면 OnTriggerEnter2D()로 감지
// 4. 필요한 UI를 표시하거나 이벤트를 실행
// 5. 영역에서 벗어날 경우 OnTriggerExit2D()로 정리 처리
public class InteractionTrigger : MonoBehaviour
{
    public GameObject interactionPopup; // 삭호작용 안내 UI (에디터에서 연결)

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            interactionPopup.SetActive(true); // 플레이어가 접근하면 팝업 표시
        }
    
        if (other.CompareTag("Player"))
        {
            interactionPopup.SetActive(false); // 플레이어가 벗어나면 팝업 숨김
        }

    }
    // 플레이어가 트리거에 들어왔을 때 실행되는 함수
    private void OnTriggerEnter2D(Collider2D other)
    {
        // 트리거에 들어온 오브젝트가 "Player" 태그를 가지고 있는지 확인
        if (other.CompareTag("Player"))
        {
            Debug.Log("상호작용 가능한 영역에 진입했습니다.");

            // 원하는 이벤트 실행
        }
    }
}
