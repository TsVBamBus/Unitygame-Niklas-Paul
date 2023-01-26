using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movment : MonoBehaviour
{
    static public Vector2 move;
    public int speed;
    bool m_FacingRight = true;

    public Animator animator;

    private void Update()
    {
        //basic Steuerung
        //Horizontal & Vertical sind in den Project Settings Definiert
        move = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")); 
        animator.SetFloat("speed", Mathf.Abs(move.x)); //lauf Animationen
       
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
    
    //Spiegelt den Spieler achsensymetrisch zur mittleren X-Achse wenn er nach links/rechts läuft
    private void Flip()
    {
  
        m_FacingRight = !m_FacingRight;

        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
   

}
