using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEnd : MonoBehaviour
{

    public GameObject Winner; //Winner Screen
    private void Start()
    {
        // bei jedem Betreten der Scene wird TimeScale auf 1 gesetzt da er am Ende jeder Scene auf 0 gesetzt wird
        Time.timeScale = 1f; 
    }
    
    IEnumerator waiter() //Erzeugung des Waiters
    {
        yield return new WaitForSeconds(10);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Finish")) //wenn Ziel erreicht wird
        {
            Winner.SetActive(true);
            Time.timeScale = 0f;
            StartCoroutine(waiter());
            LevelAcces.level = SceneManager.GetActiveScene().buildIndex + 1;
            SceneManager.LoadScene(0);
        }
        if (other.gameObject.CompareTag("DeathBarrier")) //wenn die Todes Barriere berührt wird
        {
            SceneManager.LoadScene(0);
        }
    }
    


}
