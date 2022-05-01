using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinOpenPortal : MonoBehaviour
{
    [SerializeField]
    GameObject Portals;

    int coint = 0;
    void Start()
    {
         coint = 0;
    }

    void Update()
    {
        
}
    void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.gameObject.tag == "coinssss")
        {
            coint++;

            if (coint >= 10) {
                Portals.SetActive(true);
            }
        }
    }

}

