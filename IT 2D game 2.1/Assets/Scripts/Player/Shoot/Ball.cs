using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;

    Pig p;
    
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("PigBody")) Destroy(collision.gameObject);

        //if (collision.gameObject.CompareTag("EnemyBird"));

        Destroy(gameObject);
    }
}
