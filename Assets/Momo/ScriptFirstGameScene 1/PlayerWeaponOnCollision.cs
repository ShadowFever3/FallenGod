using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeaponOnCollision : MonoBehaviour
{
    [SerializeField]
    GameObject magic;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        {
            int damage = 10;
            if (collision.gameObject.tag == "Enemie1")
            {
                Satvar.hit = true;
                Satvar.enemieDamage = 1;
                Satvar.damage = damage;
            }
           
        }
    }

}

