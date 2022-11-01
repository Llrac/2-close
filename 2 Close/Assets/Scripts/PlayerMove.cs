using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Rigidbody2D))]

public class PlayerMove : MonoBehaviour
{
    Animator anim;
    Rigidbody2D rb;

    bool isRunning = false;

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

        if (rb.velocity.x < 0 && !isRunning)
        {
            isRunning = true;
            anim.SetBool("isRunning", true);
            anim.SetTrigger("goRun");
        }
        else if (rb.velocity.x > 0 && !isRunning)
        {
            isRunning = true;
            anim.SetBool("isRunning", true);
            anim.SetTrigger("goRun");
        }
        else
        {
            isRunning = false;
            anim.SetBool("isRunning", false);
            anim.SetTrigger("goIdle");
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
