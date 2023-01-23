using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelDeath : MonoBehaviour
{
    
    public Collider2D DeathC;
    private void OnTriggerEnter2D(Collider2D D)
    {
        D = DeathC;
        Debug.Log("Trigger");
        SceneManager.LoadScene(0);
    }
}
