using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    
    void Start()
    {
        rb.velocity = transform.right * speed; //Iniziert die Geschwindigkeit
    }

    //Regelt was passiert wenn der FeuerBall den andere Objekte trifft
    // Danach soll sich der Ball selber zerstören
    public void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("PigBody")) Destroy(collision.gameObject);

        if (collision.gameObject.CompareTag("EnemyBird")) Destroy(collision.gameObject);

        if (collision.gameObject.CompareTag("Rino")) Rino.Health --;

        Destroy(gameObject);
    }
}
