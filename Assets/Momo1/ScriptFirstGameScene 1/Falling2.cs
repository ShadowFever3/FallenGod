using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling2 : MonoBehaviour
{
    int damage = 20;
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.gameObject.tag == "player")
        {
          
            Satvar.hit = true;
            Satvar.enemieDamage = 1;
            Satvar.damage = damage;
            collision.gameObject.transform.position = new Vector2(42.94f, -3.37f);
        }
    }
}
