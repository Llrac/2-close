using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Rigidbody2D))]

public class PlayerMove : MonoBehaviour
{
    Animator anim;
    Rigidbody2D rb;

    public bool hasControl = true;
    bool isWalking = false;

    float x, y;
    readonly float diagonalSpeed = 0.7f;
    public float maxSpeed = 3f;
    public float moveSpeed = 0f;
    public float acceleration = 0.8f;
    public float deacceleration = 0.8f;
    Vector2 moveDirectionVector;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        
        rb.gravityScale = 0;
    }

    void Update()
    {
        if (!hasControl)
            return;

        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");

        if (x != 0 || y != 0)
        {
            if (moveSpeed < maxSpeed)
            {
                moveSpeed += acceleration * Time.deltaTime;
            }
        }
       if ( x == 0 && y == 0)
        {
                Debug.Log("movement value of x axis" + x);     
            if (moveSpeed > 0)
            {
                moveSpeed -= deacceleration * Time.deltaTime;
            }               
        }

        if (y != 0 && x == 0)
        {
            if (!isWalking)
            {
                isWalking = true;
                anim.SetTrigger("walk");
                anim.ResetTrigger("idle");
            }
        }
        else if (x < 0)
        {
            if (transform.localScale.x > 0)
                transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
            if (!isWalking)
            {
                isWalking = true;
                anim.SetTrigger("walk");
                anim.ResetTrigger("idle");
            }
        }
        else if (x > 0)
        {
            if (transform.localScale.x < 0)
                transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
            if (!isWalking)
            {
                isWalking = true;
                anim.SetTrigger("walk");
                anim.ResetTrigger("idle");
            }
        }
        else if (rb.velocity.x == 0 && rb.velocity.y == 0 && isWalking)
        {
            isWalking = false;
            anim.SetTrigger("idle");
            anim.ResetTrigger("walk");
        }
    }

    void FixedUpdate()
    {
        if (!hasControl)
            return;

        moveDirectionVector = new Vector2(x, y).normalized;

        //if (x != 0 && y != 0)
        //{
        //    x *= diagonalSpeed;
        //    y *= diagonalSpeed;
        //}

        rb.velocity = new Vector2(moveDirectionVector.x * moveSpeed, moveDirectionVector.y * moveSpeed);
        



    }
    //void TheInputs()
    //{
    //    float moveX = Input.GetAxisRaw("Horizontal");
    //    float moveY = Input.GetAxisRaw("Vertical");

    //    moveDirectionVector = new Vector2(moveX, moveY);
    //}

    //void Movement()
    //{
    //    rb.velocity = new Vector2(moveDirectionVector.x * moveSpeed, moveDirectionVector.y*moveSpeed);
    //}
}
