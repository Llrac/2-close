using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendPlayerToRespawnDarkness : MonoBehaviour
{
    public GameObject respawnPoint;
    CameraOverlayScript cameraOverlayScript;
    KeyPickup keyPickupScript;
    GameManager gameControllerScript;
    float timer;
    float darkTimer;
    DarknessScript darknessScript;
    void Start()
    {
        darknessScript = FindObjectOfType<DarknessScript>();
        gameControllerScript = FindObjectOfType<GameManager>();
        keyPickupScript = FindObjectOfType<KeyPickup>();
        cameraOverlayScript = FindObjectOfType<CameraOverlayScript>();
    }

    // Update is called once per frame
    void Update()
    {
        timer = cameraOverlayScript.timeInDarkness;
        if(timer > 12)
        {
            if(darknessScript.opacityLevelTimer>1)
            {
                darkTimer += Time.deltaTime;
                if (darkTimer > 2)
                {
                    this.transform.position = respawnPoint.transform.position;
                    keyPickupScript.theKey.SetActive(true);
                    gameControllerScript.hasGoldenKey = false;
                    darknessScript.opacityLevelTimer = 0;
                }
            }
            else
            {
                darkTimer = 0;
            }

        }
    }
}
