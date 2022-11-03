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

    float xInput, yInput;

    public float maxSpeed = 3f;
    public float moveSpeed = 0f;
    public float acceleration = 0.8f;
    public float deacceleration = 0.8f;
    Vector2 moveDirection;
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
        {
            rb.constraints = RigidbodyConstraints2D.FreezePositionX;
            rb.constraints = RigidbodyConstraints2D.FreezePositionY;
            return;
        }
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");

        if (xInput != 0 || yInput != 0)
        {
            if (moveSpeed < maxSpeed)
            {
                moveSpeed += acceleration * Time.deltaTime;
            }
        }
        if (xInput == 0 && yInput == 0)
        {
            if (moveSpeed > 0)
            {
                moveSpeed -= deacceleration * Time.deltaTime;
            }
        }

        Animation();
    }

    private void Animation()
    {
        if (yInput != 0 && xInput == 0)
        {
            if (!isWalking)
            {
                isWalking = true;
                anim.SetTrigger("walk");
                anim.ResetTrigger("idle");
            }
        }
        else if (xInput < 0)
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
        else if (xInput > 0)
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

        moveDirection = new Vector2(xInput, yInput);
        if (moveDirection.x != 0 && moveDirection.y != 0)
        {
            moveDirectionVector = moveDirection * 0.8f;
        }
        else
        {
            moveDirectionVector = moveDirection;
        }
        rb.velocity = new Vector2(moveDirectionVector.x * moveSpeed, moveDirectionVector.y * moveSpeed);
    }
}
