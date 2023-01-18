using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEnd : MonoBehaviour
{
    public Collider2D C;
    public GameObject O;
    
    private void OnTriggerEnter2D(Collider2D C)
    {
        LevelAcces.level = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(0);       
    }
}
