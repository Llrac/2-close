using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{

    public GameObject creditsPanel;

    public void StartGame()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadCreditsPanel()
    {
        creditsPanel.SetActive(!creditsPanel.activeSelf);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
