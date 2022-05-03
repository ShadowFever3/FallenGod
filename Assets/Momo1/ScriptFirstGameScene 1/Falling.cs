using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling : MonoBehaviour
{
    int damage = 50;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "player") {
            Satvar.hit = true;
            Satvar.enemieDamage = 1;
            Satvar.damage = damage;
            collision.gameObject.transform.position = new Vector2(2.01f, -1.73f);
        }
    }
}
