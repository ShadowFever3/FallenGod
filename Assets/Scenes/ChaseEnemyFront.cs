using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseEnemyFront : MonoBehaviour
{
    [SerializeField]
    GameObject enemy;

    [SerializeField]
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        Backcheck.awarebool = false;   
    }

    // Update is called once per frame
    void Update()
    {
        if(Backcheck.awarebool == true && enemy.transform.localScale.x == 0.65f){

            enemy.transform.position += (-transform.right * (1 * speed)) * Time.deltaTime;

        }else if (Backcheck.awarebool == true && enemy.transform.localScale.x == -0.65f){

            enemy.transform.position += (transform.right * (1 * speed)) * Time.deltaTime;

        }else{
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Character"){

        Backcheck.awarebool = true;
        Backcheck.awarebackbool = false;

        }
    }
}
