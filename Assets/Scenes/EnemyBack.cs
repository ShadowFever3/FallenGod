using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBack : MonoBehaviour
{
    [SerializeField]
    GameObject enemy, target;

    [SerializeField]
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Backcheck.awarebool){
        transform.position += (target.transform.position * 0.5f) * (1 * speed) * Time.deltaTime;
        Vector3 theScale = enemy.transform.localScale;
                theScale.x *= -1;
                enemy.transform.localScale = theScale; 
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
