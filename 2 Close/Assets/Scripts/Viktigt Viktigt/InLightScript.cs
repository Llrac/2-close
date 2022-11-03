using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InLightScript : MonoBehaviour
{
    SpriteRenderer darknessSprite;
    CameraOverlayScript cameraOverlayScript;
    public bool IsInLight = false;

    private void Start()
    {
        cameraOverlayScript = FindObjectOfType<CameraOverlayScript>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("SafeLight")||collision.CompareTag("SafeLightTable"))
        {
            cameraOverlayScript.isInLightBool = true;
            
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("SafeLight")||collision.CompareTag("SafeLightTable"))
        {
            cameraOverlayScript.isInLightBool = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("SafeLight"))
        {
            cameraOverlayScript.isInLightBool = false;
        }
    }
}
