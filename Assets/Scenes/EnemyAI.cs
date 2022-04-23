using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyAI : MonoBehaviour
{
    [SerializeField]
    GameObject enemy, projectile, weapon;

    [SerializeField]
    Text t;

    [SerializeField]
    float jumpspeed;

    GameObject c;

    int EnemyHP;

    bool ready;

    Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        EnemyHP = 15;
        ready = true;
        rb2d = GetComponent<Rigidbody2D>();
        t.text = EnemyHP.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(Backcheck.awarebool == true && ready == true)
        {
            StartCoroutine(shoot());
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch(collision.gameObject.tag){
            case "Ammo":
            EnemyHP -= 1;
            rb2d.AddForce(Vector3.up * jumpspeed, ForceMode2D.Impulse);
            if(transform.localScale.x == 0.65){
            rb2d.AddForce(-transform.right * (jumpspeed * 5), ForceMode2D.Impulse);
            }else if (transform.localScale.x == -0.65){
            rb2d.AddForce(transform.right * (jumpspeed * 5), ForceMode2D.Impulse);
            }

        t.text = EnemyHP.ToString();
        if(EnemyHP >= 1){
        }else{
            Destroy(enemy);
        }
            break;

            case "BombWeapon":
            EnemyHP -= 100;
            rb2d.AddForce(Vector3.up * (jumpspeed * 1.4f), ForceMode2D.Impulse);
        t.text = EnemyHP.ToString();
        if(EnemyHP >= 1){
        }else{
            Destroy(enemy);
        }
            break;

            case "ShotgunAmmo":
            EnemyHP -= 5;
            rb2d.AddForce(Vector3.up * (jumpspeed * 0.8f), ForceMode2D.Impulse);
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

    IEnumerator shoot(){
        ready = false;

        yield return new WaitForSeconds(4);

        weapon.gameObject.SetActive(false);

        if(enemy.transform.localScale.x == 0.65f){
        c = Instantiate(projectile, weapon.transform.position, weapon.transform.rotation);
            c.GetComponent<Rigidbody2D>().velocity = -transform.right * 5;
            Destroy(c, 3f);
            Destroy(projectile, 3f);
        }else if(enemy.transform.localScale.x == -0.65f){
            c = Instantiate(projectile, enemy.transform.position, enemy.transform.rotation);
            c.GetComponent<Rigidbody2D>().velocity = transform.right * 5;
            Destroy(c, 3f); 
        }

        yield return new WaitForSeconds(0.5f);

        weapon.gameObject.SetActive(true);

        ready = true;
    }
}
