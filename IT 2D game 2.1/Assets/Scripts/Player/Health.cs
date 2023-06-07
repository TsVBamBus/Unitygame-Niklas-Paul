using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Pathfinding;

public class Health : MonoBehaviour
{
    static public int Leben = 3;
    //Vector2 pBirdPush = new Vector2 (10f, 0f);
    //Vector2 nBirdPush = new Vector2(-10f, 0f);

    //public Rigidbody2D player;
    //public AIPath aIPath;

    public GameObject looserScreen;
    public GameObject playerUi;

    public GameObject Heart1;
    public GameObject Heart2;
    public GameObject Heart3;

    public Rigidbody2D rb;
    public float kbSpeed = 100f;



    public void FixedUpdate()
    {
        if (Leben <= 2) Heart3.SetActive(false);
        if (Leben <= 1) Heart2.SetActive(false);
        if (Leben <= 0)
        {
            Heart1.SetActive(false);
            LevelEnd.GameLost(looserScreen, playerUi);
        }

    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        //Bei Collision mit Vogel
        if (other.gameObject.CompareTag("EnemyBird"))
        {
            Leben--;

            Vector2 direction = (transform.position - other.transform.position).normalized;

            other.GetComponent<rb>().AddForce(direction * kbSpeed);
        }
    }
}
