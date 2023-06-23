using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RinoMove : MonoBehaviour
{
    public float speed;

    RinoWall rw;

    private void Update()
    {
        Flip();
    }

    private void FixedUpdate()
    {
        Vector2 rinoMovement = new Vector2(rw.direction, 0);
        transform.Translate(rinoMovement * Time.deltaTime * speed);
    }

    private void Flip()
    {
        if (rw.direction == -1) transform.localScale = new Vector3(26.02444f, 19.7771f, 1.4685f);

        if (rw.direction == 1) transform.localScale = new Vector3(-26.02444f, 19.7771f, 1.4685f);
    }
}
