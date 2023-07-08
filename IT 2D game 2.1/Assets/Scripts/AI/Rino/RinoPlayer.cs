using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RinoPlayer : MonoBehaviour
{
    public static bool playerInSight;

    //überprüft ob der Spieler im Player Collider vom Rino ist
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("RinoPlayerCheck"))
        {
            playerInSight = true;
        }
    }
}
