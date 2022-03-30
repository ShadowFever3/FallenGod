using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Satvar : MonoBehaviour
{
   public static bool jumping { get; set; }
   public static bool right { get; set; }
   public static bool left { get; set; }
   public static bool up { get; set; }
   public static bool down { get; set; }

        //All the damage the enemie does
   public static bool hit { get; set; }
   public static int enemieDamage { get; set; }
   public static int damage { get; set; }

    //All the player does
    public static bool playerhit { get; set; }
    public static int playerDamage { get; set; }
    public static int pdamage { get; set; }
    public static int playerScore { get; set; }

    //playerhealth
    public static bool health { get; set; }
    public static int healthamount { get; set; }
    public static int currentHealth { get; set; }

    //enemie
    public static bool enhealth { get; set; }
    public static int enhealthamount { get; set; }
    public static int encurrentHealth { get; set; }
    
    public static bool mana { get; set; }
   public static int manaamount { get; set; }
   public static int amount { get; set; }
   public static float currentmana { get; set; }


   public static int amountjump { get; set; }
   public static bool isPaused { get; set; }
   public static bool dash  { get; set; }

    public static GameObject melee { get; set; }
    public static GameObject magic { get; set; }
   



}
