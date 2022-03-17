using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpoNcOLLSION : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject)
        {
            Satvar.amountjump = 0;
            Debug.Log("Jump: " + Satvar.amountjump);
            Satvar.jumping = true;
            Debug.Log("Jump: " + Satvar.jumping);
            Satvar.dash = true;
        }
        
        
}
}
