using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeneralScript : MonoBehaviour
{
    [SerializeField]
    Canvas optionsCanvas;

    [SerializeField]
    Canvas mainmenuCanvas;


    [SerializeField]
    GameObject Image;

    [SerializeField]
    GameObject gameImage;

    [SerializeField]
    GameObject Game;

    [SerializeField]
    GameObject Menu;

  

    private void Start()
    {
        optionsCanvas.GetComponent<Canvas>().enabled = false;
        mainmenuCanvas.GetComponent<Canvas>().enabled = false;
      
    }

    private void Update()
    {
        if (optionsCanvas.GetComponent<Canvas>().enabled == true || mainmenuCanvas.GetComponent<Canvas>().enabled == true) {
            Image.SetActive(true);
            gameImage.SetActive(false);
            Game.SetActive(false);
            Menu.SetActive(true);
        } 
        
         if (mainmenuCanvas.GetComponent<Canvas>().enabled == false && optionsCanvas.GetComponent<Canvas>().enabled == false) {
            Image.SetActive(false);
            gameImage.SetActive(true);
            Game.SetActive(true);
            Menu.SetActive(false);
        }

       

    }

   

    public void quitgame()
    {
        Debug.Log("Quit Game");
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }

}