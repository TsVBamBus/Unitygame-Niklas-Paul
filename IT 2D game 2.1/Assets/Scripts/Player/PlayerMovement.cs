using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;

    public float Speed = 30f;
    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;

    

    void Update()
    {

        horizontalMove = Input.GetAxisRaw("Horizontal") * Speed;

        animator.SetFloat("speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            animator.SetBool("jump", true);
            jump = true;
            
        }
        else if (Input.GetButtonUp("Jump"))
        {
            
            jump = false;
            
        }
        
        
    }
    public void OnLanding()
    {
        //animator.SetBool("jump", false);
    }

    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        
        jump = false;

        
    }
}
