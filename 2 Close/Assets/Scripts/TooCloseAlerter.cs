using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TooCloseAlerter : MonoBehaviour
{
    public float timer = 3;
    public float timerStartValue;

    bool tooClose;
    
    GameObject playerCollisionObj;
    UIManagerScript UIManager;

    // Start is called before the first frame update
    void Start()
    {
        UIManager = FindObjectOfType<UIManagerScript>();
        timerStartValue = 3;
    }

    // Update is called once per frame
    void Update()
    {
        //UIManager.timeInCircle = timer;

        if (tooClose)
        {
            UIManager.timeInCircle = timer;
            timer -= Time.deltaTime;
            
            if (timer < 0)
            {
                //Destroy(playerCollisionObj);
            }
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerCollisionObj = collision.gameObject;
            tooClose = true;
           
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        tooClose = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        timer = timerStartValue;
        tooClose = false;
        UIManager.timeInCircle = timer;
    }
}
