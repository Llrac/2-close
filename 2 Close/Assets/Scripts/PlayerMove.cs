using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Rigidbody2D))]

public class PlayerMove : MonoBehaviour
{
    Animator anim;
    Rigidbody2D rb;

    bool isWalking = false;

    float x, y;
    float diagonalSpeed = 0.7f;

    public float Speed = 10.0f;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        
        rb.gravityScale = 0;
    }

    void Update()
    {
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");

        if (y != 0 && x == 0)
        {
            if (!isWalking)
            {
                isWalking = true;
                anim.SetBool("isWalking", true);
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
                anim.SetBool("isWalking", true);
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
                anim.SetBool("isWalking", true);
                anim.SetTrigger("walk");
                anim.ResetTrigger("idle");
            }
        }
        else if (rb.velocity.x == 0 && rb.velocity.y == 0 && isWalking)
        {
            isWalking = false;
            anim.SetBool("isWalking", false);
            anim.SetTrigger("idle");
            anim.ResetTrigger("walk");
        }
    }

    void FixedUpdate()
    {
        if (x != 0 && y != 0)
        {           
            x *= diagonalSpeed;
            y *= diagonalSpeed;
        }

        rb.velocity = new Vector2(x * Speed, y * Speed);
    }
}
