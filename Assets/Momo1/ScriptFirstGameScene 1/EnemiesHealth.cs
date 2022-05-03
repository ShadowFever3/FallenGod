using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesHealth : MonoBehaviour
{
    int playerDamage;
    bool playerhit;
    public int health = 100;
    public int encurrenthealth;
[SerializeField]
    EnemieHealthBar enemieHealth = new EnemieHealthBar();
  
    
    void Start()
    {
        playerhit = false;
        encurrenthealth = health;
        enemieHealth.SetMaxHealth(health);
        Satvar.encurrentHealth = encurrenthealth;

    }

    // Update is called once per frame
    void Update()
    {
        //Satvar.playerDamage
        if (playerDamage == 1)
        {
            if (playerhit == true)
            {
                //Satvar.playerDamage = 0;
                playerDamage = 0;
                TakeDamage1(Satvar.pdamage);
                Debug.Log("Enemie hit once");
            }
        }
        //Satvar.playerDamage
        if (playerDamage == 0)
        {
            playerhit = false;
        }

        if (encurrenthealth == 0)
        {
            Destroy(this.gameObject);
            Satvar.amountofenemies++;
            Debug.Log("EnemieDead: "+Satvar.amountofenemies);
        }

      

        /*
           if (Input.GetKeyDown(KeyCode.Alpha2)) {
               TakeDamage(damage);
           }
        */
    }

    public void TakeDamage1(int damage)
    {
        if (encurrenthealth != 0)
        {
            Satvar.pdamage = damage;
            encurrenthealth -= damage;
            enemieHealth.SetHealth(encurrenthealth);
            Satvar.encurrentHealth = encurrenthealth;
        }

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet") {
            playerDamage = 1;
            playerhit = true;
        }
    }


}
