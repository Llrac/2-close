using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLockScript : MonoBehaviour
{
    GameController gameControllerScript;
    private void Awake()
    {
        gameControllerScript = FindObjectOfType<GameController>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameControllerScript.hasGoldenKey == true && collision.gameObject.tag == "Player")
        {
            Destroy(transform.parent.gameObject);
            Destroy(gameObject);
        }
    }
}
