using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class PlayerMove : MonoBehaviour
{
    Rigidbody2D rb;

    float x;
    float y;
    float diagonalSpeed = 0.7f;

    public float Speed = 10.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        rb.gravityScale = 0;
    }

    void Update()
    {
        
        x = Input.GetAxisRaw("Horizontal"); 
        y = Input.GetAxisRaw("Vertical"); 
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
