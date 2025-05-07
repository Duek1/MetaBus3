using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorTrigger : MonoBehaviour
{
    private string previousScene;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerPrefs.SetString("PreviousScene", SceneManager.GetActiveScene().name);

            SceneManager.LoadScene("MiniGameScene");
        }
    }

    public void ReturnToPreviousScene()
    {
        string previousScene = PlayerPrefs.GetString("PreviousScene", "MainStage");
        SceneManager.LoadScene(previousScene);
    }
}
