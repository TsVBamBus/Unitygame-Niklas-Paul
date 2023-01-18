using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelDeath : MonoBehaviour
{
    
    public Collider2D D;
    private void OnTriggerEnter2D(Collider2D D)
    {
        Debug.Log("Trigger");
        SceneManager.LoadScene(0);
    }
}
