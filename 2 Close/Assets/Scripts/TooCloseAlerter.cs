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
            UIManager.timeInDetectionZoneMaxValue = timer;
            timer -= Time.deltaTime;
            
            if (timer < 2.5f)
            {
                UIManager.redOverScreen = true;
                Debug.Log("RedOverScreen set to true");
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
        UIManager.redOverScreen = false;
        timer = timerStartValue;
        tooClose = false;
        UIManager.timeInDetectionZoneMaxValue = timer;
    }
}
