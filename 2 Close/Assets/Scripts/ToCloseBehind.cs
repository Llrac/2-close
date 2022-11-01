using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToCloseBehind : MonoBehaviour
{
    public float timer = 3;
    public float timerStartValue = 3;
    bool toClose;
    GameObject playerCollisionObj;
    UIManagerScript uIManager;
    // Start is called before the first frame update
    void Start()
    {
        uIManager = FindObjectOfType<UIManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        uIManager.timeInCircle = timer;

        if (toClose)
        {
            timer -= Time.deltaTime;
            
            if (timer < 0)
            {
                Destroy(playerCollisionObj);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerCollisionObj = collision.gameObject;
            toClose = true;
           
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        timer = timerStartValue;
        toClose = false;
    }
}
