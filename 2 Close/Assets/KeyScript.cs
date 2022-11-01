using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    GameController gameControllerScript;
    private void Awake()
    {
        gameControllerScript = FindObjectOfType<GameController>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameControllerScript.hasGoldenKey = true;
            Destroy(this.gameObject);
        }
    }
}
