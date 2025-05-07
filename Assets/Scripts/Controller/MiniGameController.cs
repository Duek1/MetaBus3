using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// EndMiniGame()�� ȣ��Ǹ� gameOver�� true�� ����
// Update()���� �� �����Ӹ��� elapsedTime�� ����
// ���� �ð��� returnDelay���� Ŀ���� LoadScene()�� ȣ���Ͽ� ����
public class MiniGameController : MonoBehaviour
{
    public GameObject gameOverPanel; // ���� �� ǥ���� UI
    public Text resultText;
    public float returnDelay = 2.5f; // ���ͱ��� ��� �ð�

    private bool gameOver = false; // ���� ���� Ȯ��
    private float elapsedTime = 0f; // �ð� ������ ����

    public void EndMiniGame(bool success, int finalScore)
    {
        if (gameOver) return;
        gameOver = true;

        // ���� ����
        ScoreManager.Instance.score = finalScore;
        ScoreManager.Instance.SaveHighScore();
        PlayerPrefs.SetInt("LastScore", finalScore);
        PlayerPrefs.Save();

        // UI ���
        gameOverPanel.SetActive(true);
        resultText.text = success ? " ����!" : "����!";

        // Ÿ�̸� �ʱ�ȭ
        elapsedTime = 0f;
    }

    private void Update()
    {
        // ���� ���� �� �ð� ���� -> ���� �ð� �� �� ����
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
