using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthPotions : MonoBehaviour
{
    [SerializeField]
    GameObject Potion;
    [SerializeField]
    HealthBar healthbar = new HealthBar();
    PlayerHealth playerHealth = new PlayerHealth();

    [SerializeField]
    int health = 10;
    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        if (Satvar.currentHealth <= 50) { 
        if (collision.gameObject.tag == "player") {
            // healthbar.SetHealth(playerHealth.currenthealth += 50);
            Satvar.healthamount = health;
            Satvar.health = true;
                Destroy(Potion);
            }
            
        }
}
}
