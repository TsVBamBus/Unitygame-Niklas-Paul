using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Pathfinding;

public class Health : MonoBehaviour
{
    static public int Leben = 3;

    public GameObject looserScreen;
    public GameObject playerUi;
    public GameObject rinoHealthBar;

    public GameObject Heart1;
    public GameObject Heart2;
    public GameObject Heart3;

    public Rigidbody2D rb;
    public float bKbSpeed;
    public float pKbSpeed;
    public float rKbSpeed;

    Pig p;

    private LevelEnd levelEnd;

    private void Start()
    {
        levelEnd = GameObject.FindGameObjectWithTag("Player").GetComponent<LevelEnd>(); //Referenz zum LevelEnd Script auf dem Spieler
    }

    //Soblad der Spieler leben abgezogen bekommt soll er weniger Herzen haben
    // Wenn er keine Leben mehr hat soll er sterben
    public void FixedUpdate()
    {
        if (Leben <= 2) Heart3.SetActive(false);
        if (Leben <= 1) Heart2.SetActive(false);
        if (Leben <= 0)
        {
            Heart1.SetActive(false);
            levelEnd.GameLost(looserScreen, playerUi);
        }

    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        //Bei Collision mit Vogel
        if (other.gameObject.CompareTag("EnemyBird"))
        {
            Leben--;

            Vector2 bDirection = (transform.position - other.transform.position).normalized; //Richtung der Kraft

            rb.AddForce(bDirection * bKbSpeed); //Inizierung der Kraft
        }
        if (other.gameObject.CompareTag("PigBody"))
        {
            Leben--;

            Vector2 pDirection = (transform.position - other.transform.position).normalized; //Richtung der Kraft

            rb.AddForce(pDirection * pKbSpeed); //Inizierung der Kraft
        }
        if (other.gameObject.CompareTag("PigHead"))
        {
            Destroy(other.gameObject.transform.parent.gameObject);
        }
        if (other.gameObject.CompareTag("Rino"))
        {
            Leben--;

            Vector2 rDirection = (transform.position - other.transform.position).normalized; //Richtung der Kraft

            rb.AddForce(rDirection * rKbSpeed); //Inizierung der Kraft
        }
    }

    // Wenn der Spieler in die Nähe vom Rino kommt soll die Lebensanzeige vom Rino angezeigt werden
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("RinoHealthBar")) rinoHealthBar.SetActive(true);
    }
}
