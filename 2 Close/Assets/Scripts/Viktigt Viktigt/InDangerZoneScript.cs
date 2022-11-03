using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InDangerZoneScript : MonoBehaviour
{
    GameManager gameControllerScript;
    public GameObject respawnPoint;
    CameraOverlayScript cameraOverlayScript;
    public bool isInDanger = false;
    float inDangerTimer;

    private void Start()
    {
        gameControllerScript = FindObjectOfType<GameManager>();
        cameraOverlayScript = FindObjectOfType<CameraOverlayScript>();
    }

    private void Update()
    {
        if (cameraOverlayScript.isInDangerBool == true)
        {
            inDangerTimer += Time.deltaTime;
            if (inDangerTimer > 0.65f)
            {
                this.transform.position = respawnPoint.transform.position;
                gameControllerScript.ResetLevel();
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
