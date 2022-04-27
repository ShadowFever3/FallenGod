using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{



    void Update()
    {
        //creates the ray
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector2.up) * 30f);

        //whenever it hits print the debug
        var hits = Physics2D.RaycastAll(transform.position, transform.TransformDirection(Vector2.up), 30f);

        if (hits.Length > 0)
        {

            foreach (var h in hits)
            {
                Debug.Log("Hit : " + h.collider.name);
            }
        }
    }
}