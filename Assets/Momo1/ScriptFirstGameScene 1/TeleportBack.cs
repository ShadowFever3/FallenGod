using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportBack : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "player")
        {

            collision.gameObject.transform.position = new Vector2(73.43f, -3.61f);
        }
    }
}

