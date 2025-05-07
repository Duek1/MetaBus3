using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance {  get; private set; } // 전역 접근용 인스턴스

    public int score = 0;

    public Text scoreText; // 얼라이먼트는 옵션들의 정렬을 바꿀 때 씀
    public Text lastScoreText;
    public Text bestScoreText;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // 씬 전환 시 파괴되지 않도록 설정
        }
        else
        {
            Destroy(gameObject); // 중복 방지
        }
    }

    private void Start()
    {
        UpdateScoreUI();

        int lastScore = PlayerPrefs.GetInt("LastScore", 0);
        int bestScore = PlayerPrefs.GetInt("HighScore", 0);

        lastScoreText.text = $"이번 점수 : {lastScore}";
        bestScoreText.text = $"최고 점수 : {bestScore}";
    }

    public void AddScore(int value)
    {
        score += value;
        UpdateScoreUI();
    }

    private void UpdateScoreUI()
    {
        if (scoreText != null)
            scoreText.text = $"점수: {score}";
    }

    public void ResetScore()
    {
        score = 0;
        UpdateScoreUI();
    }

    public void SaveHighScore()
    {
        int bestScore = PlayerPrefs.GetInt("HighScore", 0); // 저장된 최고 점수 불러오기

        if (score > bestScore)
        {
            PlayerPrefs.SetInt("HighScore", score); // 최고 점수 갱신
            PlayerPrefs.Save(); // 즉시 저장
        }
    }

    public void EndGame()
    {
        ScoreManager.Instance.SaveHighScore(); // 최고 점수 저장
        PlayerPrefs.SetInt("LastScore", ScoreManager.Instance.score); // 현재 점수 저장
        PlayerPrefs.Save();

        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMap"); // 매인 맵 복귀
    }
}
