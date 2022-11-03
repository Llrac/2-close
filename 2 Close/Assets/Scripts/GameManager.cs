using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    Scene scene;

    public static GameManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        scene = SceneManager.GetActiveScene();
    }

    public bool hasGoldenKey = false;

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(scene.buildIndex + 1);
    }
}
