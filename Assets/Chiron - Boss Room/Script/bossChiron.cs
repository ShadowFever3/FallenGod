using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossChiron : MonoBehaviour
{
    float speed;
    [SerializeField]
    GameObject arrow;
    [SerializeField]
    Transform arrowPosition;
    [SerializeField]
    int arrowSpeed;
    [SerializeField]
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        speed = arrowSpeed* Time.fixedDeltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            shotArrow();
        }
    }

    private void shotArrow()
    {
        GameObject newArrow = Instantiate(arrow, arrowPosition.position, arrowPosition.rotation);
        Rigidbody2D rb2d = newArrow.GetComponent<Rigidbody2D>();

        Vector2 direction = gameObject.transform.position - player.transform.position;
        Vector2 newvector = direction * speed;
        rb2d.velocity = newvector;

        //rb2d.AddForce((player.GetComponent<Rigidbody2D>().position - newArrow.GetComponent<Rigidbody2D>().position) * arrowSpeed);
    }
}
