using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowDamage : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "player")
        {
            Satvar.hit = true;
            Satvar.enemieDamage = 1;
            Satvar.damage = 20;
            Debug.Log(Satvar.currentHealth);
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }
}