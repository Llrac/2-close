using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InDangerZoneScript : MonoBehaviour
{
    CameraOverlayScript cameraOverlayScript;
    public bool isInDanger = false;

    private void Start()
    {
        cameraOverlayScript = FindObjectOfType<CameraOverlayScript>();
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
