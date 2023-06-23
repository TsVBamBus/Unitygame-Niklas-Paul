using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RinoWall : MonoBehaviour
{
    public int direction = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Rino Wall")) direction = direction * -1;
    }
}
