using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance {  get; private set; } // ���� ���ٿ� �ν��Ͻ�

    public int score = 0;

    public Text scoreText; // ����̸�Ʈ�� �ɼǵ��� ������ �ٲ� �� ��
    public Text lastScoreText;
    public Text bestScoreText;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // �� ��ȯ �� �ı����� �ʵ��� ����
        }
        else
        {
            Destroy(gameObject); // �ߺ� ����
        }
    }

    private void Start()
    {
        UpdateScoreUI();

        int lastScore = PlayerPrefs.GetInt("LastScore", 0);
        int bestScore = PlayerPrefs.GetInt("HighScore", 0);

        lastScoreText.text = $"�̹� ���� : {lastScore}";
        bestScoreText.text = $"�ְ� ���� : {bestScore}";
    }

    public void AddScore(int value)
    {
        score += value;
        UpdateScoreUI();
    }

    private void UpdateScoreUI()
    {
        if (scoreText != null)
            scoreText.text = $"����: {score}";
    }

    public void ResetScore()
    {
        score = 0;
        UpdateScoreUI();
    }

    public void SaveHighScore()
    {
        int bestScore = PlayerPrefs.GetInt("HighScore", 0); // ����� �ְ� ���� �ҷ�����

        if (score > bestScore)
        {
            PlayerPrefs.SetInt("HighScore", score); // �ְ� ���� ����
            PlayerPrefs.Save(); // ��� ����
        }
    }

    public void EndGame()
    {
        ScoreManager.Instance.SaveHighScore(); // �ְ� ���� ����
        PlayerPrefs.SetInt("LastScore", ScoreManager.Instance.score); // ���� ���� ����
        PlayerPrefs.Save();

        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMap"); // ���� �� ����
    }
}
