using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// EndMiniGame()이 호출되면 gameOver를 true로 설정
// Update()에서 매 프레임마다 elapsedTime을 누적
// 누적 시간이 returnDelay보다 커지면 LoadScene()을 호출하여 복귀
public class MiniGameController : MonoBehaviour
{
    public GameObject gameOverPanel; // 종료 시 표시할 UI
    public Text resultText;
    public float returnDelay = 2.5f; // 복귀까지 대기 시간

    private bool gameOver = false; // 종료 상태 확인
    private float elapsedTime = 0f; // 시간 누적용 변수

    public void EndMiniGame(bool success, int finalScore)
    {
        if (gameOver) return;
        gameOver = true;

        // 점수 저장
        ScoreManager.Instance.score = finalScore;
        ScoreManager.Instance.SaveHighScore();
        PlayerPrefs.SetInt("LastScore", finalScore);
        PlayerPrefs.Save();

        // UI 출력
        gameOverPanel.SetActive(true);
        resultText.text = success ? " 성공!" : "실패!";

        // 타이머 초기화
        elapsedTime = 0f;
    }

    private void Update()
    {
        // 게임 종료 후 시간 누적 -> 일정 시간 후 맵 복귀
        if (gameOver)
        {
            elapsedTime += Time.deltaTime;

            if (elapsedTime >= returnDelay)
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene("MainMap");
            }
        }
    }
}
