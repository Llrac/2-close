using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManagerScript : MonoBehaviour
{
<<<<<<< Updated upstream
    public SpriteRenderer[] deathGradient;
    public TMP_Text detectionCircleTimer;
    public float timeInCircle = 3;

=======
    public SpriteRenderer redOverWholeScreenSprite;
    public SpriteRenderer[] deathGradiant;
    public TMP_Text detectionCircleTimer;
    public float timeInDetectionZoneMaxValue = 3;
    public bool redOverScreen = false;
    float timeInDarkness = 3;
    float redScreenTimer = 0;
>>>>>>> Stashed changes
    void Update()
    {
        //Red over screen warning
        if (redOverScreen == true)
        {
            Debug.Log("this is redOverScreen bool in UIManager");
            
            redScreenTimer += Time.deltaTime;
            if (redScreenTimer > 1f) 
            {
                Debug.Log("It should be red on screen");
                if (redOverWholeScreenSprite.enabled == false)
                {
                    redOverWholeScreenSprite.enabled = true;
                    Debug.Log("It should be red on screen2");
                }
                else if (redOverWholeScreenSprite.enabled == false)
                {
                    redOverWholeScreenSprite.enabled = true;
                }

<<<<<<< Updated upstream
=======
                redScreenTimer = 0;              
            }
            
        }
        detectionCircleTimer.text = "" + timeInDetectionZoneMaxValue;
        
        if (timeInDetectionZoneMaxValue > 2.8)
        {
            
            //if (timeInDetectionZoneMaxValue < 2.5f)
            //{
            //    deathGradiant[0].enabled = true;
            //}
            
        }

>>>>>>> Stashed changes
        //enemy gradiant activate or inactivate sprite
        for (int i = 0; i < deathGradient.Length; i++)
        {
            if (timeInDarkness > 2.5)
            {
                deathGradient[i].enabled = false;
            }
        }
        if (timeInDarkness < 2.5f)
        {
            deathGradient[0].enabled = true;
        }
        if (timeInDarkness < 2f)
        {
            deathGradient[1].enabled = true;
        }
        if (timeInDarkness < 1.5f)
        {
            deathGradient[2].enabled = true;
        }
        if (timeInDarkness < 1f)
        {
            deathGradient[3].enabled = true;
        }
        if (timeInDarkness < 0.5f)
        {
            deathGradient[4].enabled = true;
        }
        if (timeInDarkness < 0.25f)
        {
            deathGradient[5].enabled = true;
        }
        if (timeInDarkness < 0.0f)
        {
            deathGradient[6].enabled = true;
        }
    }
}
