using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    GameController gameControllerScript;

    private void Awake()
    {
        gameControllerScript = FindObjectOfType<GameController>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameControllerScript.hasGoldenKey = true;
            Destroy(this.gameObject);
        }
    }
}
