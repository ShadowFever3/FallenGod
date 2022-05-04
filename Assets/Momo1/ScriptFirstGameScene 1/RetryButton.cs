using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RetryButton : MonoBehaviour
{

    [SerializeField]
    GameObject projectile1;
    [SerializeField]
    GameObject projectile2;

    public Button yourButton;

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    private void Update()
    {
      
       
      
    }

    void TaskOnClick()
    {
        Satvar.playerScore = 0;
        Satvar.magic = projectile1;
        Satvar.melee = projectile2;
        Satvar.amountofenemies = 0;
        Satvar.currentHealth = 100;
    }
}