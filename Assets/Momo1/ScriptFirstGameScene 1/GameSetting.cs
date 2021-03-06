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

    public GameObject Music;

    private float MusicVolume = 1f;


    [SerializeField]
    private AudioSource audioSource;
    public void Start()
    {
        //audioSource.Play();
        slider.value = PlayerPrefs.GetFloat("volume");
        //audioSource.volume = MusicVolume;

    }

    private void Update()
    {
        // audioSource.volume = MusicVolume;
        PlayerPrefs.SetFloat("volume", AudioListener.volume);
    }
    public void SetFullscreen(bool isfullscreen)
    {
        Screen.fullScreen = isfullscreen;
    }
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
