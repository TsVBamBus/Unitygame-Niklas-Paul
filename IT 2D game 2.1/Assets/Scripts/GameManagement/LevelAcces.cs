using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelAcces : MonoBehaviour
{
    static public int level = 1; //globale Variable f�r Aktuellen Level Stand

    //jede play Methode ist dem jeweiligem Button im Menu zugeordnet
    public void playLevel1()
    {
        if (level >= 1) SceneManager.LoadScene(1);
        
        else { }
    }
    public void playLevel2()
    {
        if (level >= 2) SceneManager.LoadScene(2);
        
        else { }
    }
    public void playLevel3()
    {
        if (level >= 3) SceneManager.LoadScene(3);
        
        else { }
    }



}
