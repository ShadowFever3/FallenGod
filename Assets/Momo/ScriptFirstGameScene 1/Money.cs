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

    string scorekey = "scoreValue";
    private void Start()
    {
        t.text = Satvar.playerScore.ToString();
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.gameObject.tag == "player")
        {
            PlayerPrefs.SetInt(scorekey, scoreValue);
            Satvar.playerScore += PlayerPrefs.GetInt(scorekey);
            t.text = Satvar.playerScore.ToString();

            Destroy(MySelf);

        }




    }
}