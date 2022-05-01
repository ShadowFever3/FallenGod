using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBack : MonoBehaviour
{
    [SerializeField]
    GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        Backcheck.awarebackbool = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "player"){
            Vector3 theScale = enemy.transform.localScale;
                theScale.x *= -1;
                enemy.transform.localScale = theScale;
        Backcheck.awarebackbool = true;
        Backcheck.awarebool = false; 
        }
    }
}
