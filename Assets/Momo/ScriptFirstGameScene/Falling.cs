using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player") {
            Satvar.damage = 50;
            collision.gameObject.transform.position = new Vector2(-15.24f, -0.86f);
        }
    }
}
