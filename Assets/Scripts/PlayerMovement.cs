using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D rbody;

    private void Awake()
    {
        rbody = GetComponent<Rigidbody2D>();
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
        
        if (Input.GetKey(KeyCode.Space))
        {
            rbody.velocity = new Vector2(rbody.velocity.x, speed);
        }
    }
}
