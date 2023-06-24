using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RinoPlayer : MonoBehaviour
{
    public static bool playerInSight;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Rino"))
        {
            playerInSight = true;
        }
    }
}
