using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SETCURRENTHEALTH : MonoBehaviour
{
    public void Start()
    {
        Satvar.currenthealthactivate = true;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            if (Satvar.currenthealthactivate == true)
            {
                Satvar.currentHealth = 100;

                Satvar.currenthealthactivate = false;

            }
        }
    }
}
