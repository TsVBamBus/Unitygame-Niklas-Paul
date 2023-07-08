using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pig : MonoBehaviour
{
    public float speed;
    private int direction = 1;

    public GameObject pig;


    private void Update()
    {
        Flip();
    }

    //GEschwindigkeit des Pigs
    private void FixedUpdate()
    {
        Vector2 pigMovement = new Vector2(direction, 0);
        transform.Translate(pigMovement * Time.deltaTime * speed);
    }

    //Pig ändert Richtung wenn es die Wand berührt
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wall")) direction = direction * -1; 
    }

    //spiegelt das Pig bei Richtungswechsel
    private void Flip()
    {
        if (direction == -1) transform.localScale = new Vector3(5.874f, 6.823248f, 1.4685f);

        if (direction == 1) transform.localScale = new Vector3(-5.874f, 6.823248f, 1.4685f);
    }
}
