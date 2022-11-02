using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManagerScript : MonoBehaviour
    
{
    public SpriteRenderer[] deathGradiant;
    public TMP_Text detectionCircleTimer;
    public float timeInCircle = 3;
    void Update()
    {
        detectionCircleTimer.text = "" + timeInCircle;


        //enemy gradiant activate or inactivate sprite
        for (int i = 0; i < deathGradiant.Length; i++)
        {
            if (timeInCircle > 2.5)
            {
                deathGradiant[i].enabled = false;
            }
        }
        if (timeInCircle < 2.5f)
        {
            deathGradiant[0].enabled = true;
        }
        if (timeInCircle < 2f)
        {
            deathGradiant[1].enabled = true;
        }
        if (timeInCircle < 1.5f)
        {
            deathGradiant[2].enabled = true;
        }
        if (timeInCircle < 1f)
        {
            deathGradiant[3].enabled = true;
        }
        if (timeInCircle < 0.5f)
        {
            deathGradiant[4].enabled = true;
        }
        if (timeInCircle < 0.25f)
        {
            deathGradiant[5].enabled = true;
        }
        if (timeInCircle < 0.0f)
        {
            deathGradiant[6].enabled = true;
        }

    }
}
