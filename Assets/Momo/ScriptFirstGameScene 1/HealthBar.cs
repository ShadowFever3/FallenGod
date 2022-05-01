using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    public Slider slider;
    public Gradient gradient;
    public Image fill;
    public void SetHealth(int health)
    {
        //slider.value = health;
        PlayerPrefs.SetInt("value", Satvar.currentHealth);
        slider.value = PlayerPrefs.GetInt("value");
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
    public void SetMaxHealth()
    {
        slider.maxValue = 100;
        if (Satvar.currentHealth == 100)
        {
            slider.value = 100;
        }
        gradient.Evaluate(1f);


    }
}
