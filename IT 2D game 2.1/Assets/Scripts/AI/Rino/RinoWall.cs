using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RinoWall : MonoBehaviour
{
    public static int direction = 1;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Rino")) direction = direction * -1;
    }
}
