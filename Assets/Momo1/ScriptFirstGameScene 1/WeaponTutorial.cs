using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponTutorial : MonoBehaviour
{
    [SerializeField]
    GameObject projectile1;
    [SerializeField]
    GameObject projectile2;
    [SerializeField]
    GameObject projectile3;

    public void Start()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Weapon1":
                Satvar.magic = projectile1;
                Satvar.pdamage = 5;
                break;
            case "Weapon2":
                Satvar.melee = projectile2;
                Satvar.pdamage = 15;
                break;
            case "Weapon3":
                Satvar.melee = projectile3;
                Satvar.pdamage = 10;
                break;
            default:

                break;
        }
    }
}
