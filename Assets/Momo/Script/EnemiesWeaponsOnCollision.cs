using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesWeaponsOnCollision : MonoBehaviour
{
    [SerializeField]
    GameObject magic;
    public void OnTriggerEnter2D(Collider2D collision) { 
    {
        int damage = 10;
        if (collision.gameObject.tag == "player") {
            Satvar.hit = true;
            Satvar.enemieDamage = 1;
            Satvar.damage = damage;
        }
        if (collision.gameObject.tag == "player" || collision.gameObject.tag == "walls" || collision.gameObject.tag == "Plateforms")
            {
                Destroy(magic);
}
    }
        }

}
