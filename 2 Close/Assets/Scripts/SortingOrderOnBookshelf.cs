using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortingOrderOnBookshelf : MonoBehaviour
{
    SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "BehindBookshelf")
        {
            
            spriteRenderer.sortingOrder = -1;
        }       
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "BehindBookshelf")
        {
            spriteRenderer.sortingOrder = 0;
        }
       

    }
}
