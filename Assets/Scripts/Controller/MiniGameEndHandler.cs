using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MiniGameEndHandler : MonoBehaviour
{
    public int score;

    public Text scoreText;

    public void EndMiniGame()
    {
        PlayerPrefs.SetInt("LastMiniGameScore", score); //��������
        PlayerPrefs.Save();

        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMap");
    }

    private void Start()
    {
        int score = PlayerPrefs.GetInt("LastMiniGameScore", 0);
        scoreText.text = $"�̴ϰ��� ����: {score}";
    }
}
