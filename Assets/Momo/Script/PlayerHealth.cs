using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    GameObject Music;
   public static PlayerHealth playerHealth;


    public int health = 100;
    
    [SerializeField]
    HealthBar healthbar = new HealthBar();
    void Start()
    {
        Satvar.hit = false;
        Satvar.currentHealth = health;
        healthbar.SetMaxHealth(health);
    }

    // Update is called once per frame
    void Update()
    {
        if (Satvar.enemieDamage == 1)
        {
            if (Satvar.hit == true) {
                Satvar.enemieDamage = 0;
                TakeDamage(Satvar.damage);
            }
        }

        if (Satvar.enemieDamage == 0) {
            Satvar.hit = false;
        }

        if (Satvar.currentHealth == 0) {
            SceneManager.LoadScene("GameOver");
            Destroy(Music);
        }
       
        if (Satvar.health == true){
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

    public void TakeDamage(int damage) {
        if (Satvar.currentHealth != 0){
            Satvar.damage = damage;
        Satvar.currentHealth -= damage;
        healthbar.SetHealth(Satvar.currentHealth);
    }

}
    public void HealthPotion(int amount)
    {
              Satvar.healthamount = amount;
              Satvar.currentHealth += amount;
                
            healthbar.SetHealth(Satvar.currentHealth); 
            
        }
}
