using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaBar : MonoBehaviour
{
    public Slider slider;

    private int maxStamina = 100;
  
    

    private WaitForSeconds regenTick = new WaitForSeconds(0.1f);
    private Coroutine regen;

    public static ManaBar manabar;
    private void Awake()
    {
       manabar = this;
    }
    void Start()
    {
        Satvar.mana = true;
        Satvar.currentmana = maxStamina;
        slider.maxValue = maxStamina;
        slider.value = maxStamina;
    }

  
    void Update()
    { 
        if (Satvar.manaamount == 1)
        {
            Satvar.mana = false;
            Debug.Log("It's: " + Satvar.mana);
        }
       else if (Satvar.manaamount == 0)
        {
            Satvar.mana = true;
            Debug.Log("It's: " + Satvar.mana);

        }
        
    }

    public void UseStamina(int amount)

    {
        Satvar.amount = amount;
        if ((Satvar.currentmana - Satvar.amount) >= 0)
        {
          
            Debug.Log("It's: " + Satvar.manaamount);
            Satvar.currentmana -= amount;
            slider.value=Satvar.currentmana;

            if (regen != null)
                StopCoroutine(regen);


            regen = StartCoroutine(RegenStamina());

            Debug.Log(Satvar.currentmana);

        }
        else
        {
            Satvar.manaamount = 1;
            Debug.Log("It's: " + Satvar.manaamount);
        }

    }
    

    private IEnumerator RegenStamina()
    {
        yield return new WaitForSeconds(2);
        
        while(Satvar.currentmana < maxStamina)
        {
            if ((Satvar.currentmana - Satvar.amount) >= 10)
            {
                Debug.Log(Satvar.currentmana);
                Satvar.manaamount = 0;
            }
            else {
                Satvar.manaamount = 1;
            }
     
            Satvar.currentmana += maxStamina / 100;
            slider.value = Satvar.currentmana;
            yield return regenTick;
        }
        regen = null;
    }
}
