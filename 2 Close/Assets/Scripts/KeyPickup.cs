using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    
    
    GameManager gameControllerScript;
    public GameObject theKey;
    private void Awake()
    {
        
        theKey = this.gameObject;
        gameControllerScript = FindObjectOfType<GameManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            
            gameControllerScript.hasGoldenKey = true;
            this.gameObject.SetActive(false);
        }
    }
}
