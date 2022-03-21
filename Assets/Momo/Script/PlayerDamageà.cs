using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamageà : MonoBehaviour
{
    [SerializeField]
    GameObject enemieHealthhide1, enemieHealthhide2, enemieHealthhide3, enemieHealthhide4;
    public void OnCollisionEnter2D(Collision2D collision)
    {
   
          
            if (collision.gameObject.tag == "Enemie1")
                {
            Satvar.playerhit = true;
            Satvar.playerDamage = 1;
            

            if (Satvar.encurrentHealth == 0)
                {
                    Destroy(collision.gameObject);
                    enemieHealthhide1.SetActive(false);

                }
                }

        else if(collision.gameObject.tag == "Enemie2")
                {
            Satvar.playerhit = true;
            Satvar.playerDamage = 1;
            
            if (Satvar.encurrentHealth == 0)
                    {
                        Destroy(collision.gameObject);
                        enemieHealthhide2.SetActive(false);

                    }
                }

        else if (collision.gameObject.tag == "Enemie3")
            {
            Satvar.playerhit = true;
            Satvar.playerDamage = 1;
        
            if (Satvar.encurrentHealth == 0)
                {
                    Destroy(collision.gameObject);
                    enemieHealthhide3.SetActive(false);

                }
            
                 }

        else if (collision.gameObject.tag == "Enemie4")
               {
            Satvar.playerhit = true;
            Satvar.playerDamage = 1;
            
            if (Satvar.encurrentHealth == 0)
            {
                Destroy(collision.gameObject);
                enemieHealthhide4.SetActive(false);

            }
        }
    }
        }
    
    


