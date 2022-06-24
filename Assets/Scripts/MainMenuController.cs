using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public GameObject gameoverScreen;
    private int playerLeft = 4;

    private void Update()
    {
        Debug.Log("Sisa player :" + playerLeft);
        if (playerLeft <= 1)
        {
            GameOver();
            Time.timeScale = 0;
        }
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void TutorialGame()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void GameOver()
    {
        gameoverScreen.SetActive(true);
    }

    public void ReducePlayer()
    {
        playerLeft--;
    }
}
