using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    GameObject Portals;

    public static PlayerHealth playerHealth;

    
    public int health = 100;

    [SerializeField]
    HealthBar healthbar = new HealthBar();
    void Start()
    {
        Portals.SetActive(false);
        Satvar.hit = false;

        PlayerPrefs.SetInt("valu", Satvar.currentHealth);
        healthbar.SetHealth(PlayerPrefs.GetInt("valu"));
    }

    // Update is called once per frame
    void Update()
    {
        if (Satvar.enemieDamage == 1)
        {
            if (Satvar.hit == true)
            {
                Satvar.enemieDamage = 0;
                TakeDamage(Satvar.damage);
            }
        }

        if (Satvar.enemieDamage == 0)
        {
            Satvar.hit = false;
        }

        if (Satvar.currentHealth <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }

        if (Satvar.health == true)
        {
            HealthPotion(50);
            Satvar.health = false;
        }

        if (Satvar.health == false)
        {
            HealthPotion(0);
        }

        /*
           if (Input.GetKeyDown(KeyCode.Alpha2)) {
               TakeDamage(damage);
           }
        */
    }

    public void TakeDamage(int damage)
    {
        if (Satvar.currentHealth >= 0)
        {
            Satvar.damage = damage;
            Satvar.currentHealth -= damage;


            PlayerPrefs.SetInt("values", Satvar.currentHealth);
            healthbar.SetHealth(PlayerPrefs.GetInt("values"));

            //healthbar.SetHealth(Satvar.currentHealth);
        }

    }
    public void HealthPotion(int amount)
    {
        Satvar.healthamount = amount;
        Satvar.currentHealth += amount;

        PlayerPrefs.SetInt("val", Satvar.currentHealth);
        healthbar.SetHealth(PlayerPrefs.GetInt("val"));

        // healthbar.SetHealth(Satvar.currentHealth); 

    }
}
