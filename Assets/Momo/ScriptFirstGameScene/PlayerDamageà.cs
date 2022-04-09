using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamageà : MonoBehaviour
{
    [SerializeField]
    GameObject enemieHealthhide2;
    [SerializeField]
    GameObject enemieHealthhide3;
    public void OnCollisionEnter2D(Collision2D collision)
    {
   
          
          
         if(collision.gameObject.tag == "Enemie2")
        {
            Satvar.playerhit = true;
            Satvar.playerDamage = 1;
            Satvar.pdamage = 20;

            if(Satvar.currentHealth==0)
            enemieHealthhide2.SetActive(true);


    }


        if (collision.gameObject.tag == "Enemie4")
        {
            Satvar.playerhit = true;
            Satvar.playerDamage = 1;
            Satvar.pdamage = 10;

            if (Satvar.currentHealth == 0)
                enemieHealthhide3.SetActive(true);


        }
    }
}






