using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEnd : MonoBehaviour
{
    public GameObject winnerScreen; //Winner Screen
    public GameObject looserScreen;
    private void Start()
    {
        // bei jedem Betreten der Scene wird TimeScale auf 1 gesetzt da er am Ende jeder Scene auf 0 gesetzt wird
        Time.timeScale = 1f; 
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Finish")) //wenn Ziel erreicht wird
        {
            Time.timeScale = 0f;
            winnerScreen.SetActive(true);
            StartCoroutine(waiter());
            
        }
        if (other.gameObject.CompareTag("DeathBarrier")) //wenn die Todes Barriere berührt wird
        {
            GameLost();
        }
    }

    void GameLost()
    {
        Time.timeScale = 0f;
        looserScreen.SetActive(true);
    }

    IEnumerator waiter() //Erzeugung des Waiters
    {
        yield return new WaitForSecondsRealtime(5f);
        LevelAcces.level = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(0);
    }



}
