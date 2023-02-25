using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovementInput : MonoBehaviour
{
    private Vector2 movement;
    private Rigidbody2D rbody;

    [SerializeField] private int speed = 5;

    private void Awake()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    private void OnMovement(InputValue value)
    {
        movement = value.Get<Vector2>();
    }

    private void FixedUpdate()
    {
        rbody.velocity = movement * speed;
    }
}
