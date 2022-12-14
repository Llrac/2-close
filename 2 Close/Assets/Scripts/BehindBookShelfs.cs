using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehindBookShelfs : MonoBehaviour
{
    SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("BehindBookshelf"))
        {
            spriteRenderer.enabled = true;
        }
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("BehindBookshelf"))
        {
            spriteRenderer.enabled = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("BehindBookshelf"))
        {
            spriteRenderer.enabled = false;
        }
        
    }
}
