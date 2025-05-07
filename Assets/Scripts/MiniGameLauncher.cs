using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;

public class MiniGameLauncher : MonoBehaviour
{
    [SerializeField] private string miniGamePath = @"C:\Users\ppsik\My project(4)\Bulids\PC";

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            LaunchMiniGame();
        }
    }

    private void LaunchMiniGame()
    {
        try
        {
            Process.Start(miniGamePath);
            UnityEngine.Debug.Log("미니게임 실행됨!");
        }
        catch (System.Exception e)
        {
            UnityEngine.Debug.LogError("실행 실패: " + e.Message);
        }
    }
}

