using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemieDamage : MonoBehaviour
{
    int damage = 5;
    private void OnCollisionEnter2D(Collision2D collision)
    {
      
        if (collision.gameObject.tag == "player")
        {
            Satvar.hit = true;
            Satvar.enemieDamage = 1;
            Satvar.damage = damage;
        }
      
    }

}
