using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManagerScript : MonoBehaviour
{
    public SpriteRenderer[] deathGradient;
    public TMP_Text detectionCircleTimer;
    public float timeInCircle = 3;

    void Update()
    {
        detectionCircleTimer.text = "" + timeInCircle;

        //enemy gradiant activate or inactivate sprite
        for (int i = 0; i < deathGradient.Length; i++)
        {
            if (timeInCircle > 2.5)
            {
                deathGradient[i].enabled = false;
            }
        }
        if (timeInCircle < 2.5f)
        {
            deathGradient[0].enabled = true;
        }
        if (timeInCircle < 2f)
        {
            deathGradient[1].enabled = true;
        }
        if (timeInCircle < 1.5f)
        {
            deathGradient[2].enabled = true;
        }
        if (timeInCircle < 1f)
        {
            deathGradient[3].enabled = true;
        }
        if (timeInCircle < 0.5f)
        {
            deathGradient[4].enabled = true;
        }
        if (timeInCircle < 0.25f)
        {
            deathGradient[5].enabled = true;
        }
        if (timeInCircle < 0.0f)
        {
            deathGradient[6].enabled = true;
        }
    }
}
