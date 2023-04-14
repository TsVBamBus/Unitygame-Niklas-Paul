using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    static public int Leben = 3;
    public GameObject Heart1;
    public GameObject Heart2;
    public GameObject Heart3;

    public void Update()
    {
        switch(Leben){
            case 2: Heart3.SetActive(false);
                break;
            case 1: Heart2.SetActive(false);
                break;
            case 0: Heart1.SetActive(false);
                break;
        }
  
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("EnemyBird"))
        {
            Leben--;
            Debug.Log(Leben);
        }
    }
}
