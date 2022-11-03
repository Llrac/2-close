using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InDangerZoneScript : MonoBehaviour
{
    GameManager gameControllerScript;
    public GameObject RespawnPoint;
    CameraOverlayScript cameraOverlayScript;
    public bool isInDanger = false;
    float inDangerTimer;
    KeyPickup keyPickupScript;
    private void Start()
    {
        gameControllerScript = FindObjectOfType<GameManager>();
        keyPickupScript = FindObjectOfType<KeyPickup>();
        cameraOverlayScript = FindObjectOfType<CameraOverlayScript>();
    }

    private void Update()
    {
        if (cameraOverlayScript.isInDangerBool == true)
        {
            inDangerTimer += Time.deltaTime;
            if (inDangerTimer > 2)
            {
                this.transform.position = RespawnPoint.transform.position;
                keyPickupScript.theKey.SetActive(true);
                gameControllerScript.hasGoldenKey = false;
                Debug.Log(gameControllerScript.hasGoldenKey + ("bool"));
            }
        }
        else
        {
            inDangerTimer = 0;
        }
 
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("DangerZone"))
        {
            cameraOverlayScript.isInDangerBool = true;
            
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("DangerZone"))
        {
            cameraOverlayScript.isInDangerBool = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("DangerZone"))
        {
            cameraOverlayScript.isInDangerBool = false;
        }
    }
}
