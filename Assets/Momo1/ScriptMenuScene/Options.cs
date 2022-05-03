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
    GameObject Image;

    [SerializeField]
    GameObject OptionImage;



    private void Start()
    {
        optionsCanvas.GetComponent<Canvas>().enabled = false;
        mainmenuCanvas.GetComponent<Canvas>().enabled = true;
        OptionImage.SetActive(false);
        Image.SetActive(true);
    }

    private void Update()
    {
        if (optionsCanvas.GetComponent<Canvas>().enabled == true)
        {
            Image.SetActive(false);
            OptionImage.SetActive(true);

        }
        if (mainmenuCanvas.GetComponent<Canvas>().enabled == true)
        {
            Image.SetActive(true);
            OptionImage.SetActive(false);

        }
    }
}
