using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralScript : MonoBehaviour
{
    [SerializeField]
    Canvas optionsCanvas;
    [SerializeField]
    Canvas mainmenuCanvas;
    private void Start()
    {
        optionsCanvas.GetComponent<Canvas>().enabled = false;
      
    }

    private void Update()
    {
      
    }

    public void quitgame()
    {
        Debug.Log("Quit Game");
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }

}