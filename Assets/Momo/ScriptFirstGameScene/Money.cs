using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Money : MonoBehaviour
{
    [SerializeField]
    int scoreValue;
    [SerializeField]
    Text t;
    [SerializeField]
    GameObject MySelf;
   // [SerializeField]
   // GameObject Portals;


  //  private void Start()
   // {
   //     Portals.SetActive(false);
   // }
    private void OnTriggerEnter2D(Collider2D collision)
    {


        Satvar.playerScore += scoreValue;
        t.text = Satvar.playerScore.ToString();



    
        Destroy(MySelf);
        



    }
}
