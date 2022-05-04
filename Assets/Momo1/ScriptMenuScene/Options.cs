using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Options : MonoBehaviour
{
    [SerializeField]
    Canvas optionsCanvas;

    [SerializeField]
    Canvas mainmenuCanvas;

    [SerializeField]
    Canvas ControlsCanvas;


    [SerializeField]
    GameObject Image;

    [SerializeField]
    GameObject OptionImage;

    [SerializeField]
    GameObject ControlsImage;



    private void Start()
    {
        optionsCanvas.GetComponent<Canvas>().enabled = false;
        ControlsCanvas.GetComponent<Canvas>().enabled = false;
        mainmenuCanvas.GetComponent<Canvas>().enabled = true;
        OptionImage.SetActive(false);
        ControlsImage.SetActive(false);
        Image.SetActive(true);
    }

    private void Update()
    {
        if (optionsCanvas.GetComponent<Canvas>().enabled == true)
        {
            Image.SetActive(false);
            ControlsImage.SetActive(false);
            OptionImage.SetActive(true);

        }
        if (mainmenuCanvas.GetComponent<Canvas>().enabled == true)
        {
            Image.SetActive(true);
            ControlsImage.SetActive(false);
            OptionImage.SetActive(false);

        }

        if (ControlsCanvas.GetComponent<Canvas>().enabled == true)
        {
            Image.SetActive(false);
            ControlsImage.SetActive(true);
            OptionImage.SetActive(false);

        }
    }
}
