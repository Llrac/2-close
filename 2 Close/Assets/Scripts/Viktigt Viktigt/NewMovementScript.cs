using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMovementScript : MonoBehaviour
{
    Rigidbody2D rb;

    //PlayerSpeeds
   
    float walkSpeed = 4f;
    float speedLimiter = 0.7f;
    float inputX;
    float inputY;
    float speedMin = 0.1f;
    float decelerationSpeed;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        inputX = Input.GetAxisRaw("Horizontal");
        inputY = Input.GetAxisRaw("Vertical");
    }
    private void FixedUpdate()
    {
        if (inputX != 0 || inputY != 0)
        {
            if (inputX != 0 && inputY != 0)
            {
                inputX *= speedLimiter;
                inputY *= speedLimiter;
            }

            rb.velocity = new Vector2(inputX * walkSpeed, inputY * walkSpeed);
        }
        else
        {
            // If speed is bigger then acceleration
            if(walkSpeed > speedMin)
            {
                //Remove speed depending on deceleration
                walkSpeed -= decelerationSpeed * Time.deltaTime;
                //keeps going in direction if lower then minimumspeed

            }

            
        }
    }
}
