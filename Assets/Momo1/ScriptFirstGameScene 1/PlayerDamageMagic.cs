using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamageMagic : MonoBehaviour
{

    public void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.tag == "Enemie2")
        {
            Satvar.playerhit = true;
            Satvar.playerDamage = 1;
            Satvar.pdamage = 20;


        }


    }
}






