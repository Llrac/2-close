using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarknessScript : MonoBehaviour
{
    
    float opacityLevelTimer = 0;
    float opacityLevel;
     SpriteRenderer darknessSpriteRenderer;
    CameraOverlayScript cameraOverlayScript;
    private void Start()
    {
        cameraOverlayScript = FindObjectOfType<CameraOverlayScript>();
        darknessSpriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        
        opacityLevel = cameraOverlayScript.timeInDarkness;
        if (cameraOverlayScript.isInLightBool == false)
        {
            opacityLevelTimer += 0.15f * Time.deltaTime;         
            darknessSpriteRenderer.color =  new Color(0, 0, 0, opacityLevelTimer);
        }
        else if (cameraOverlayScript.isInLightBool == true)
        {
            if (opacityLevelTimer > 0)
            {
                opacityLevelTimer -= 0.30f * Time.deltaTime;
            }
            
            darknessSpriteRenderer.color = new Color(0, 0, 0, opacityLevelTimer);
        }
    }
}
