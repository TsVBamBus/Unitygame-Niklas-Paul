using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movment : MonoBehaviour
{
    static public Vector2 move;
    public int speed;

    public Animator animator;

    private coinmanager m;

    void Start()
    {
        m = GameObject.FindGameObjectWithTag("Text").GetComponent<coinmanager>();
    }

    private void Update()
    {
        //basic Steuerung
        //Horizontal & Vertical sind in den Project Settings Definiert
        move = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")); 
        animator.SetFloat("speed", Mathf.Abs(move.x)); //lauf Animationen
       
        transform.Translate(move * speed * Time.deltaTime);

        Flip();
    }

    //Spiegelt den Spieler achsensymetrisch zur mittleren X-Achse wenn er nach links/rechts läuft
    private void Flip()
    {
        if (move.x < 0) transform.localScale = new Vector3(-10.71964f, 12.35508f, 1f);

        if (move.x > 0) transform.localScale = new Vector3(10.71964f, 12.35508f, 1f);
    }
     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Cherry")
        {
            m.AddCoin();
            Destroy(other.gameObject);
        }
    }
   

}
