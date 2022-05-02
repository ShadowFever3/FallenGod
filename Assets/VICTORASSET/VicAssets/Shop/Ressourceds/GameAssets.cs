using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAssets : MonoBehaviour
{
    
    public Sprite HealthPotion;
   
    public Sprite bomb;

    public Sprite RecoilMagic;

    public Sprite Sword;


    private static GameAssets _i;

    public static GameAssets i
    {
        get
        {
            if (_i == null) _i = Instantiate(Resources.Load<GameAssets>("GameAssets"));
            return _i;

        }
    }


    
}
