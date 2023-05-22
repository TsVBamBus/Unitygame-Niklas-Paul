using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    static public int Leben = 3;
    public GameObject looserScreen;
    public GameObject playerUi;
    public GameObject Heart1;
    public GameObject Heart2;
    public GameObject Heart3;

    public void Update()
    {
        if (Leben <= 2) Heart3.SetActive(false);
        if (Leben <= 1) Heart2.SetActive(false);
        if (Leben <= 0)
        {
            Heart1.SetActive(false);
            LevelEnd.GameLost(looserScreen, playerUi);
        }

    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("EnemyBird"))
        {
            Leben = Leben - 1;
            Debug.Log(Leben);
        }
    }
}
