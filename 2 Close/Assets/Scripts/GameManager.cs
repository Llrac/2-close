using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    Scene scene;
    KeyPickup keyPickupScript;
    DoorLock doorLockScript;
    EnemyMove[] enemyMoveScripts;

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
        keyPickupScript = FindObjectOfType<KeyPickup>();
        doorLockScript = FindObjectOfType<DoorLock>();
        enemyMoveScripts = FindObjectsOfType<EnemyMove>();
    }

    public bool hasGoldenKey = false;

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(scene.buildIndex + 1);
        ResetLevel();
    }

    public void ResetLevel()
    {
        keyPickupScript.theKey.SetActive(true);
        hasGoldenKey = false;
        doorLockScript.isOpen = false;
        doorLockScript.isEntering = false;
        foreach (EnemyMove enemy in enemyMoveScripts)
        {
            EnemyMove enemyScript = enemy.gameObject.GetComponent<EnemyMove>();
            enemy.transform.position = enemyScript.startTransform.position;
        }
    }
}
