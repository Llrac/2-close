using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOverlayScript : MonoBehaviour
{
    public InLightScript playerInLightScript;
    float timeInDarkness = 0;
    public SpriteRenderer[] darknessGradiant;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //If player is not in the light, start timer and and on CameraOverLay Darkness
        if (playerInLightScript.IsInLight == false)
        {
            timeInDarkness += Time.deltaTime;
            Debug.Log("is in darkness");
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
        if (playerInLightScript.IsInLight == true)
        {
            for (int i = 0; i < darknessGradiant.Length; i++)
            {
                darknessGradiant[i].enabled = false;
            }
            timeInDarkness = 0f;
            Debug.Log("is in light");
        }

        //Darkness activation stages

       
    }
}
