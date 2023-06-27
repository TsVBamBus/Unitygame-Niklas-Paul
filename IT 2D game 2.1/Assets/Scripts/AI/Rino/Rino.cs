using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rino : MonoBehaviour
{
    public float speed = 7;
    public int direction = 1;
    public bool hitWall = false;

    public static float Health = 100f;

    public Image healthBar;

    RinoWall rw;

    private void Start()
    {
        Health = 100f;
    }

    private void Update()
    {
        Flip();
        if(RinoPlayer.playerInSight == true)
        {
            speed = 20;
        }
        if(hitWall == true)
        {
            speed = 7;
            RinoPlayer.playerInSight = false;
        }
        if(Health <= 0)
        {
            Destroy(gameObject);
        }
        healthBar.fillAmount = Health / 100f;
    }

    private void FixedUpdate()
    {
        Vector2 rinoMovement = new Vector2(direction, 0);
        transform.Translate(rinoMovement * Time.deltaTime * speed);
    }

    private void Flip()
    {
        if (direction == -1) transform.localScale = new Vector3(26.02444f, 19.7771f, 1.4685f);

        if (direction == 1) transform.localScale = new Vector3(-26.02444f, 19.7771f, 1.4685f);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Rino Wall"))
        {
            hitWall = true;
            direction = direction * -1;
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Rino Wall")) hitWall = false;
    }

}
