using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{



    void Update()
    {
       
        //creates the ray
        RaycastHit2D[] hits = Physics2D.RaycastAll(transform.position, new Vector3(0, 10, 0));
        Debug.DrawRay(transform.position,transform.up*10, Color.green);
        //whenever it hits print the debug
        foreach (var h in hits)
        {

            if (h.transform.tag == "player")
            {
                Shop.isTriger = true;

            }
            else {

                break;
            }
           
        }
    }
}

