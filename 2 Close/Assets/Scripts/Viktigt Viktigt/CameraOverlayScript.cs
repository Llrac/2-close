using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOverlayScript : MonoBehaviour
{
    float timeInDarkness = 0;
    public SpriteRenderer[] darknessGradiant;
    public SpriteRenderer warningLight;
    public SpriteRenderer warningOutLine;
    public bool isInLightBool;
    public bool isInDangerBool;
    // Start is called before the first frame update

    public float warningLightTimer = 0f;
    public float warningRate = 0.3f;

    void Start()
    {
        isInDangerBool = false;
        isInLightBool = false;
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
            if (timeInDarkness > 3f)
            {
                darknessGradiant[0].enabled = true;
            }
            if (timeInDarkness > 6f)
            {
                darknessGradiant[1].enabled = true;
            }
            if (timeInDarkness > 9f)
            {
                darknessGradiant[2].enabled = true;
            }
            if (timeInDarkness > 12f)
            {
                darknessGradiant[3].enabled = true;
            }
            if (timeInDarkness > 15f)
            {
                darknessGradiant[4].enabled = true;
            }
            if (timeInDarkness > 18f)
            {
                darknessGradiant[5].enabled = true;
            }
            if (timeInDarkness > 21f)
            {
                darknessGradiant[6].enabled = true;
            }
        }
        if (isInLightBool == true)
        {
            for (int i = 0; i < darknessGradiant.Length; i++)
            {
                darknessGradiant[i].enabled = false;
            }
            timeInDarkness = 0f;
            Debug.Log("is in light");
        }
    }

    private void DangerDetection()
    {
        if (isInDangerBool == true)
        {
            //warningLight.enabled = true;
            warningOutLine.enabled = true;

            warningLightTimer += Time.deltaTime;

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
            warningLight.enabled = false;
            warningOutLine.enabled = false;
        }
    }
}
