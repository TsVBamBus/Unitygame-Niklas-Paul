using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipFirePoint : MonoBehaviour
{
    bool m_FacingRight = true;

    //Je nachdem wie der Spieler steht soll sich auch der Firepoint spiegeln
    void Update()
    {
        if (Movment.move.x > 0 && !m_FacingRight)
        {
            Flip();
        }

        else if (Movment.move.x < 0 && m_FacingRight)
        {

            Flip();
        }
    }

    void Flip()
    {
        m_FacingRight = !m_FacingRight;

        transform.Rotate(0f, 180f, 0f);
    }
}
