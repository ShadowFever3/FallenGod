using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesHealth : MonoBehaviour
{

    public int health = 100;

    [SerializeField]
    EnemieHealthBar enemieHealth = new EnemieHealthBar();
  
    
    void Start()
    {
        Satvar.playerhit = false;
        Satvar.encurrentHealth = health;
        enemieHealth.SetMaxHealth(health);
    }

    // Update is called once per frame
    void Update()
    {
     
        if (Satvar.playerDamage == 1)
        {
            if (Satvar.playerhit == true)
            {
                Satvar.playerDamage = 0;
                TakeDamage1(Satvar.pdamage);
                Debug.Log("Enemie hit once");
            }
        }

        if (Satvar.playerDamage == 0)
        {
            Satvar.playerhit = false;
        }

        if (Satvar.encurrentHealth == 0)
        {
            Destroy(this.gameObject);
        }


        /*
           if (Input.GetKeyDown(KeyCode.Alpha2)) {
               TakeDamage(damage);
           }
        */
    }

    public void TakeDamage1(int damage)
    {
        if (Satvar.encurrentHealth != 0)
        {
            Satvar.pdamage = damage;
            Satvar.encurrentHealth -= damage;
            enemieHealth.SetHealth(Satvar.encurrentHealth);
        }

    }
  

}
