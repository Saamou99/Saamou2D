using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Movement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D rbody;
    private Animator animator;
    private bool grounded;

    private void Awake()
    {   // Grab reference from Rigidbody2d and Animator from object;
        rbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        rbody.velocity = new Vector2(horizontalInput * speed, rbody.velocity.y);

        // Flips the player (Left/Right)
        if (horizontalInput > 0.01f)
        {
            transform.localScale = Vector3.one;
        }
        else if (horizontalInput < -0.01f)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }

        if (Input.GetKey(KeyCode.Space) && grounded)
        {
          Jump();
        }
        else if (Input.GetKey(KeyCode.W) && grounded)
        {
            Jump();
        }
        
        //Set Animator parameters;
        animator.SetBool("Run", horizontalInput != 0);
        animator.SetBool("Grounded", grounded);
    }

    private void Jump()
    {
        rbody.velocity = new Vector2(rbody.velocity.x, speed);
        animator.SetTrigger("Jump");        
        grounded = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            grounded = true;
        }
    }
}
