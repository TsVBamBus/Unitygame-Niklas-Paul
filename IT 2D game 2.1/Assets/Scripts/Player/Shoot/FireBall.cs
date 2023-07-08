using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    public Transform firePoint;
    public GameObject ballPrefab;

    //Wenn die Fire Taste gedrückt wird soll der Ball abgeschossen werden
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    //Ein Prefab des Feuerballs wird iniziert
    void Shoot()
    {
        Instantiate(ballPrefab, firePoint.position, firePoint.rotation);
    }
}
