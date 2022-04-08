using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFront : MonoBehaviour
{
    [SerializeField]
    GameObject target, enemy;

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
        enemy.transform.Translate(target.transform.position * (1 * speed) * Time.deltaTime);
        Debug.Log("I see you now");  
        }else if(Backcheck.awarebool == true && enemy.transform.localScale.x == -0.65f){
        enemy.transform.Translate(-target.transform.position * (1 * speed) * Time.deltaTime);
        Debug.Log("You can't escape me");  
        }else{
            Debug.Log(enemy.transform.localScale.x);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Character"){
        if(enemy.transform.localScale.x == 0.65f || enemy.transform.localScale.x == -0.65f){
        Backcheck.awarebool = true;
        Backcheck.awarebackbool = false;  
        }else{
            Debug.Log(enemy.transform.localScale.x);
        }
        }
    }
}