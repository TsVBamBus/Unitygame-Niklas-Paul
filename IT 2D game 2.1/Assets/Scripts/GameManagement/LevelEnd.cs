using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEnd : MonoBehaviour
{
    public Collider2D WinnerC;
    public GameObject Winner;

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(10);
    }

    private void OnTriggerEnter2D(Collider2D W)
    {
        W = WinnerC;
        Winner.SetActive(true);
        Time.timeScale = 0f;
        StartCoroutine(waiter());
        LevelAcces.level = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(0);       
    }
    


}
