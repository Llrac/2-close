using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOverlayScript : MonoBehaviour
{
    public SpriteRenderer[] darknessGradient;
    public SpriteRenderer warningLight;
    public SpriteRenderer warningOutLine;
    public bool isInLightBool;
    public bool isInDangerBool;
    public float opacityLevel = 0.1f;
    public float warningLightTimer = 0f;
    public float warningRate = 0.3f;
    public float timeInDarkness = 0;
    public float darknessRate = 2;
    float opacityLevelTimer;

    void Start()
    {
        isInDangerBool = false;
        isInLightBool = false;

        int childIndex = 0;
        foreach (Transform child in transform)
        {
            if (child.gameObject.name != "WarningLight" && child.gameObject.name != "DarknessOnScreen")
            {
                darknessGradient[childIndex] = child.gameObject.GetComponent<SpriteRenderer>();
                childIndex++;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Light
        //If player is not in the light, start timer and and on CameraOverLay Darkness
        LightDetection();

        //DangerZones
        //If in danger zones
        DangerDetection();

    }
    private void LightDetection()
    {
        if (isInLightBool == false)
        {
            timeInDarkness += Time.deltaTime;
            
            for (int i = 0; i < darknessGradient.Length; i++)
            {
                if (timeInDarkness > 3 * (i + 1))
                {
                    darknessGradient[i].enabled = true;
                }
            }
        }
        if (isInLightBool == true)
        {
            for (int i = 0; i < darknessGradient.Length; i++)
            {
                if (darknessGradient[i] != null)
                    darknessGradient[i].enabled = false;
            }
            timeInDarkness = 0f;
        }
    }

    private void DangerDetection()
    {
        if (isInDangerBool == true)
        {
            
            //warningLight.enabled = true;
            warningOutLine.enabled = true;
            
            warningLightTimer += Time.deltaTime;
            //Opacity timer
            opacityLevelTimer = 0.2f * Time.deltaTime;
            opacityLevel += opacityLevelTimer;
            warningLight.color = new Color(255f, 0f, 0f, opacityLevel);
            
            //Makes the light come on and off
            if (warningLightTimer > warningRate)
            {
                if (warningLight.enabled == false)
                {
                    warningLight.enabled = true;
                }
                else if (warningLight.enabled == true)
                {
                    warningLight.enabled = false;
                }
                warningLightTimer = 0;
            }

        }
        //If NOT in danger zones
        if (isInDangerBool == false)
        {
            opacityLevel = 0f;
            opacityLevelTimer = 0f;

            warningLight.enabled = false;
            warningOutLine.enabled = false;
        }
    }
}
