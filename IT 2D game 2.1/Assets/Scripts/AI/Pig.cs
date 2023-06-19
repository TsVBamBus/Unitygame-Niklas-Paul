using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pig : MonoBehaviour
{
    public float speed;
    private int direction = 1;    

    private void Update()
    {
        Flip();
    }
    private void FixedUpdate()
    {
        Vector2 pigMovement = new Vector2(direction, 0);
        transform.Translate(pigMovement * Time.deltaTime * speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wall")) direction = direction * -1; 
    }

    private void Flip()
    {
        if (direction == -1) transform.localScale = new Vector3(5.874f, 6.823248f, 1.4685f);

        if (direction == 1) transform.localScale = new Vector3(-5.874f, 6.823248f, 1.4685f);
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
