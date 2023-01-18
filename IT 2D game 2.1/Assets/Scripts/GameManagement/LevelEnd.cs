using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEnd : MonoBehaviour
{
    public Collider2D C;
    private void OnTriggerEnter2D(Collider2D C)
    {
        Debug.Log("Trigger");
        SceneManager.LoadScene(0);
    }
}
