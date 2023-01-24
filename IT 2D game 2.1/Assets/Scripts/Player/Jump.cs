using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    Rigidbody2D rb;

    [Header("Jump System")]
    [SerializeField] int jumpPower;
    [SerializeField] float fallMultiplier;
    [SerializeField] float jumpTime;
    [SerializeField] float jumpMultiplier;


    public Transform groundcheckCollider;
    public LayerMask groundLayer;
    Vector2 vecGravity;

    const float groundCheckRadius = 0.2f;
    bool isJumping;
    float jumpCounter;
    bool isGrounded;

    public Animator animator;
    void Start()
    {
        vecGravity = new Vector2(0, -Physics2D.gravity.y);
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        
        
        //springt ab
        if (Input.GetButtonDown("Jump") && isGrounded == true) 
        {
            
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
            isJumping = true;
            jumpCounter = 0;
            
        }

        //Bewegung nach oben
        if (rb.velocity.y > 0 && isJumping) 
        {
           
            jumpCounter += Time.deltaTime;
            if (jumpCounter > jumpTime) isJumping = false;

            float t = jumpMultiplier / jumpTime;
            float currentJumpM = jumpMultiplier;

            if(t > 0.5)
            {
                currentJumpM = jumpMultiplier * (1 - t);
            }

            rb.velocity += vecGravity * currentJumpM * Time.deltaTime;
        }

        //lässt springen los
        if (Input.GetButtonUp("Jump")) 
        {
            isJumping = false;
            jumpCounter = 0;

            if (rb.velocity.y > 0)
            {
                rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.6f);
            }
        }

        //fällt
        if (rb.velocity.y < 0) 
        {
            rb.velocity -= vecGravity * fallMultiplier * Time.deltaTime;
            
        }
       
        


    }
    /*
    private void Update()
    {
    
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            animator.SetBool("jump", true);
        }

        
    }
    */
    void Grouncheck()
    {
        isGrounded = false;

        Collider2D[] colliders = Physics2D.OverlapCircleAll(groundcheckCollider.position, groundCheckRadius, groundLayer);
        if (colliders.Length > 0) isGrounded = true;

        animator.SetBool("jump", !isGrounded);
    }
}
