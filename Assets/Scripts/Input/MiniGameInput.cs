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
            if (CanEnterMiniGame()) // 조건을 확인 UI가 켜져있을 때
            {
                EnterMiniGame();
            } 
        }       
    }

    private bool CanEnterMiniGame()
    {
        // 상호작용 가능 영역에 들어가 있고 UI가 켜져있을 때
        return true;
    }

    private void EnterMiniGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(miniGameSceneName);
    }
}
