using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFront : MonoBehaviour
{
    [SerializeField]
    GameObject target, enemy;

    [SerializeField]
    float speed, jumpspeed;

    Rigidbody2D rb2d;

    bool inair;
    // Start is called before the first frame update
    void Start()
    {
        Backcheck.awarebool = false;
        rb2d = enemy.GetComponent<Rigidbody2D>();
        inair = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Backcheck.awarebool == true && enemy.transform.localScale.x == 0.65f && inair == false){
        enemy.transform.position = Vector3.MoveTowards(enemy.transform.position, new Vector3(target.transform.position.x, target.transform.position.y), Time.deltaTime * speed);
        Vector3 targ = target.transform.position;
        targ.z = 0f;
        Vector3 objectPos = enemy.transform.position;
        targ.x = targ.x - objectPos.x;
        targ.y = targ.y - objectPos.y;
        float angle = Mathf.Atan2(-targ.y, -targ.x) * Mathf.Rad2Deg;
        if(inair == false && angle > 80 || inair == false && angle < -80){
        enemy.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        }else if(inair == false && angle > 45 && angle < 80 || inair == false && angle < -45 && angle > -80){
            StartCoroutine(Jump());           
        }else{
        enemy.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
        }

        }else if(Backcheck.awarebool == true && enemy.transform.localScale.x == -0.65f){
        enemy.transform.position = Vector3.MoveTowards(enemy.transform.position, new Vector3(-target.transform.position.x, -target.transform.position.y), Time.deltaTime * speed);
        Vector3 targ = target.transform.position;
        targ.z = 0f;
        Vector3 objectPos = enemy.transform.position;
        targ.x = targ.x - objectPos.x;
        targ.y = targ.y - objectPos.y;
        float angle = Mathf.Atan2(-targ.y, -targ.x) * Mathf.Rad2Deg;
        if(inair == false && angle > 80 || inair == false && angle < -80){
        enemy.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        }else if(inair == false && angle > 45 && angle < 80 || inair == false && angle < -45 && angle > -80){
            StartCoroutine(Jump());             
        }else{
        enemy.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
        } 
        }else{
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "player"){
        if(enemy.transform.localScale.x == 0.65f || enemy.transform.localScale.x == -0.65f){
        Backcheck.awarebool = true;
        Backcheck.awarebackbool = false;  
        }else{
        }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "ShotgunAmmo")
        {

        }else{
            inair = false;
        }
    }

    IEnumerator Jump(){
        if(inair == false){
        rb2d.AddForce(Vector3.up * jumpspeed, ForceMode2D.Impulse);
        Debug.Log("Jump");
        inair = true;
        yield return new WaitForSeconds(0.5f);
        enemy.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        yield return new WaitForSeconds(0.5f);
        rb2d.AddForce(-Vector3.right * jumpspeed, ForceMode2D.Impulse);
        }
    }
}