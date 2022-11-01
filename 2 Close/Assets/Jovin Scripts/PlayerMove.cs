using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody2D body;

    float x;
    float y;
    float diagonalSpeed = 0.7f;

    public float Speed = 10.0f;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
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

        body.velocity = new Vector2(x * Speed, y * Speed);
    }
}
