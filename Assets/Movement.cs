using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rigidBody;
    public GroundCheck groundCheck;
    public float speed = 5;
    public float jumpForce = 1000;
    private float input;

    private void Update()
    {
        input = 0;
        if (Input.GetKey(KeyCode.A))
            input = -speed;
        if (Input.GetKey(KeyCode.D))
            input = speed;
        if (Input.GetKeyDown(KeyCode.Space) && groundCheck.Grounded)
            rigidBody.AddForce(new Vector2(0, jumpForce));
    }

    void FixedUpdate()
    {
        rigidBody.AddForce(new Vector2((input - rigidBody.velocity.x) / Time.deltaTime, 0));
    }
}