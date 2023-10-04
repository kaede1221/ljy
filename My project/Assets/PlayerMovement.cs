using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    public int maxJumps = 2; 
    private Rigidbody2D rb;
    private int jumpsRemaining;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jumpsRemaining = maxJumps;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }
    private void Move()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        if (Input.GetKey(KeyCode.A))
        {
            horizontalInput = -1f;
        }
        else if ( Input.GetKey(KeyCode.D))
        {
            horizontalInput = 1f;
        }
        else
        {
            horizontalInput = 0f;
        }

        Vector2 movement = new Vector2(horizontalInput * moveSpeed, rb.velocity.y);
        rb.velocity = movement;
    }

    private void Jump()
    {
        if (Input.GetKey(KeyCode.W))
        {
            
            
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            }
        }
        
    }
/*
    private void CheckGround(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            jumpsRemaining = maxJumps;
        }
    }*/

}


   