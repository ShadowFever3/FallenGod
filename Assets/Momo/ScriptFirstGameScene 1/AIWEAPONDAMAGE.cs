using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIWEAPONDAMAGE : MonoBehaviour
{
   
    int damage = 20;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        {

            if (collision.gameObject.tag == "player")
            {
                Satvar.hit = true;
                Satvar.enemieDamage = 1;
                Satvar.damage = damage;
            }
          
    }

    }
}
