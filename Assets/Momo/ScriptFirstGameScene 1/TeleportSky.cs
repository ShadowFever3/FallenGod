using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportSky : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "player")
        {

            collision.gameObject.transform.position = new Vector2(-5.51f, 14.25f);
        }
    }
}
