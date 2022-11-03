using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortingOrderPlayerInLight : MonoBehaviour
{
    SpriteRenderer playerSprite;
    private void Start()
    {
        playerSprite = GetComponent<SpriteRenderer>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "SafeLight")
        {
            Debug.Log("Should change player sorting order");
            playerSprite.sortingOrder = -2;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "SafeLight")
        {
            Debug.Log("Should change player sorting order");
            playerSprite.sortingOrder = -2;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "SafeLight")
        {
            playerSprite.sortingOrder = 0;
        }
    }
}
