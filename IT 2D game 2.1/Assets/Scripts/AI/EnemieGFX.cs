using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemieGFX : MonoBehaviour
{
    public AIPath aIPath;

    // Update is called once per frame
    void Update()
    {
        if(aIPath.desiredVelocity.x > 0.01f)
        {
            transform.localScale = new Vector3(-0.9441295f, 0.8461946f, 1f);
        }
        else if (aIPath.desiredVelocity.x <= -0.01f)
        {
            transform.localScale = new Vector3(0.9441295f, 0.8461946f, 1f);
        }
    }
}
