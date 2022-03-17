using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSetting : MonoBehaviour
{
    [SerializeField]
    private Slider slider;
    [SerializeField]
    private Toggle mute;

    public void ChangeSound()
    {
        if (mute.GetComponent<Toggle>().isOn)
        {
            AudioListener.volume = 0;
        }
        else
        {
            AudioListener.volume = slider.value;

        }

    }
}
