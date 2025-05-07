using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MiniGameInput : MonoBehaviour
{
    public string miniGameSceneName = "FlappyBirdScene";

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (CanEnterMiniGame()) // ������ Ȯ�� UI�� �������� ��
            {
                EnterMiniGame();
            } 
        }       
    }

    private bool CanEnterMiniGame()
    {
        // ��ȣ�ۿ� ���� ������ �� �ְ� UI�� �������� ��
        return true;
    }

    private void EnterMiniGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(miniGameSceneName);
    }
}
