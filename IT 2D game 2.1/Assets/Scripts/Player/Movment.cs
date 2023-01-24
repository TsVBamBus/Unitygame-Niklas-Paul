using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movment : MonoBehaviour
{
    Vector2 move;
    public int speed;
    bool m_FacingRight = true;

    Rigidbody2D rb;
    public Animator animator;

    private void Update()
    {
        move = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        animator.SetFloat("speed", Mathf.Abs(move.x));
        


        transform.Translate(move * speed * Time.deltaTime);

        if (move.x > 0 && !m_FacingRight)
        {
            Flip();
        }
   
        else if (move.x < 0 && m_FacingRight)
        {
           
            Flip();  
        }
    }
    private void FixedUpdate()
    {
        rb.AddForce(move * speed, ForceMode2D.Impulse);
    }

    private void Flip()
    {
  
        m_FacingRight = !m_FacingRight;

        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
   

}
