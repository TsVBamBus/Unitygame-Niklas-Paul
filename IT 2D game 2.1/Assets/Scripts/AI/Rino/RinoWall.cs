using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RinoWall : MonoBehaviour
{
    public static int direction = 1;
    
    //wenn Rino die Wand ber�hrt solles die richtung �ndern
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Rino")) direction = direction * -1;
    }
}
