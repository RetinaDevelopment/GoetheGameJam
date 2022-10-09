using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float horizontal;
    public float speed = 10f;
    public float jumpingPower = 25f;

    private bool isFacingRight = true;
    public Animator animator;
    
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    void Update()
    {

        horizontal = Input.GetAxisRaw("Horizontal");
        animator.SetFloat("walk" , Math.Abs(horizontal));
        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
            animator.SetBool("jump", true);
        }
        if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f) rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        Flip();
    }

    private void FixedUpdate()
    {
        animator.SetBool("jump", !IsGrounded());
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
            //flip correction
            if (!isFacingRight) transform.position = transform.position - new Vector3(3.6f, 0, 0);
            else transform.position = transform.position - new Vector3(-3.6f, 0, 0);
        }
    }
}