using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeePlayerScript : MonoBehaviour
{
    SpriteRenderer spriteRender;

    private void Awake()
    {
        spriteRender = GetComponent<SpriteRenderer>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "BookShelf")
        {
            spriteRender.enabled = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        spriteRender.enabled = false;
    }
}

