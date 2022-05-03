using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    [SerializeField]
    Canvas c;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Satvar.isPaused)
            {
                Resume();
            }
            else
            {
                Pauses();
            }
        }
    }

    public void Pauses()
    {
        Time.timeScale = 0f;
        Satvar.isPaused = true;
        c.enabled = true;
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        Satvar.isPaused = false;
        c.enabled = false;
    }
}
