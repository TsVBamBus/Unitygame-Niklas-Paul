using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEnd : MonoBehaviour
{

    public GameObject Winner;
    private void Start()
    {
        Time.timeScale = 1f;
    }
    IEnumerator waiter()
    {
        yield return new WaitForSeconds(10);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            Winner.SetActive(true);
            Time.timeScale = 0f;
            StartCoroutine(waiter());
            LevelAcces.level = SceneManager.GetActiveScene().buildIndex + 1;
            SceneManager.LoadScene(0);
        }
        if (other.gameObject.CompareTag("DeathBarrier"))
        {
            Debug.Log("Trigger");
            SceneManager.LoadScene(0);
        }
    }
    


}
