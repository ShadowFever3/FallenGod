using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikesDamage : MonoBehaviour
{
    int damage = 20;
    public void OnCollisionEnter2D(Collision2D collision)
    {  

        if (collision.gameObject.tag == "player")
        {
            Satvar.hit = true;
            Satvar.enemieDamage = 1;
            Satvar.damage = damage;
        }
        
    }
}

