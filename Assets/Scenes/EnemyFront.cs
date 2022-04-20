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
        enemy.transform.position = Vector3.MoveTowards(enemy.transform.position, new Vector3(target.transform.position.x, target.transform.position.y), Time.deltaTime * speed);
        Vector3 targ = target.transform.position;
        targ.z = 0f;
        Vector3 objectPos = enemy.transform.position;
        targ.x = targ.x - objectPos.x;
        targ.y = targ.y - objectPos.y;
        float angle = Mathf.Atan2(-targ.y, -targ.x) * Mathf.Rad2Deg;
        if(angle > 89 || angle < -89){
        enemy.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        Debug.Log(angle);
        }else{
        enemy.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
        Debug.Log(angle); 
        }
        }else if(Backcheck.awarebool == true && enemy.transform.localScale.x == -0.65f){
        enemy.transform.position = Vector3.MoveTowards(enemy.transform.position, new Vector3(-target.transform.position.x, -target.transform.position.y), Time.deltaTime * speed);
        Vector3 targ = target.transform.position;
        targ.z = 0f;
        Vector3 objectPos = enemy.transform.position;
        targ.x = targ.x - objectPos.x;
        targ.y = targ.y - objectPos.y;
        float angle = Mathf.Atan2(-targ.y, -targ.x) * Mathf.Rad2Deg;
        if(angle > 89 || angle < -89){
        enemy.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        Debug.Log(angle);
        }else{
        enemy.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
        Debug.Log(angle); 
        } 
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