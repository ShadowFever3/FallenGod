using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyAI : MonoBehaviour
{
    [SerializeField]
    GameObject target, enemy, projectile;

    [SerializeField]
    float speed;

    [SerializeField]
    Text t;

    GameObject c;

    //bool awarebool;

    int EnemyHP;
    // Start is called before the first frame update
    void Start()
    {
        Backcheck.awarebool = false;
        EnemyHP = 15;
        t.text = EnemyHP.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(Backcheck.awarebool){
        transform.position += (target.transform.position * 0.5f) * (1 * speed) * Time.deltaTime;
        }


        if(Input.GetKeyDown(KeyCode.K))
        {
            c = Instantiate(projectile, enemy.transform.position + (transform.right * 0.1f), enemy.transform.rotation);
            c.GetComponent<Rigidbody2D>().velocity = transform.right * 5;
            Destroy(c, 3f);
        }  
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Character"){
            Backcheck.awarebool = true;
            Backcheck.awarebackbool = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch(collision.gameObject.tag){
            case "Ammo":
            EnemyHP -= 1;
        t.text = EnemyHP.ToString();
        if(EnemyHP >= 1){
        }else{
            Destroy(enemy);
        }
            break;

            case "BombWeapon":
            EnemyHP -= 100;
        t.text = EnemyHP.ToString();
        if(EnemyHP >= 1){
        }else{
            Destroy(enemy);
        }
            break;

            case "ShotgunAmmo":
            EnemyHP -= 5;
        t.text = EnemyHP.ToString();
        if(EnemyHP >= 1){
        }else{
            Destroy(enemy);
        }
        break;

        case "Melee":
        EnemyHP -= 5;
        t.text = EnemyHP.ToString();
        if(EnemyHP >= 1){
        }else{
            Destroy(enemy);
        }
        break;
        }
    }
}
