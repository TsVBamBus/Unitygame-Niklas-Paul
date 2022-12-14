using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class JumpPhysics : MonoBehaviour
{
    public float fallMultiplier = 2.5f;
    public float lowJumpMultiplier = 2f;

    public Animator animator;

    Rigidbody2D rb;


    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        if(0> rb.velocity.y && Input.GetButton("Jump")) {
            rb.velocity += Vector2.up * Physics2D.gravity * (fallMultiplier - 1) * Time.deltaTime;
        }
        else if (rb.velocity.y < 0 && !Input.GetButton("Jump"))
        {
            rb.velocity += Vector2.up * Physics2D.gravity * (lowJumpMultiplier - 1) * Time.deltaTime;
        }
        animator.SetFloat("yVelocity", rb.velocity.y);
    }
}
