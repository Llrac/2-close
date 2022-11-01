using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLock : MonoBehaviour
{
    GameController gameControllerScript;
    private void Awake()
    {
        gameControllerScript = FindObjectOfType<GameController>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameControllerScript.hasGoldenKey == true && collision.CompareTag("Player"))
        {
            Destroy(transform.parent.gameObject);
            Destroy(gameObject);
        }
    }
}
