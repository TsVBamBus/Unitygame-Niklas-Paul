using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    static int Leben = 3;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("EnemyBird"))
        {
            Leben = Leben - 1;
            Debug.Log("treffer");
        }
    }
}
