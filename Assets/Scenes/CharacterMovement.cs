using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField]
    GameObject Character, projectile1, projectile2, projectile3, projectile4, secretprojectile, melee1;

    [SerializeField]
    float speed, jumpspeed;

    [SerializeField]
    Text h, o;

    [SerializeField]
    Quaternion bulletrotation;

    Rigidbody2D rb2d;

    bool inair, left, right, ready;

    GameObject c, projectile, melee;

    private GameObject[] getCount, getCount1;

    int count, count1, HP;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = Character.GetComponent<Rigidbody2D>();
        inair = false;
        left = false;
        right = true;
        HP = 20;
        h.text = HP.ToString();
        o.gameObject.SetActive(false);
        ready = true;
        projectile = projectile1;
        melee = melee1;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * (1 * speed);
            right = true;
            left = false;
        }

        if(Input.GetKey(KeyCode.A))
        {
            transform.position += transform.right * (-1 * speed);
            right = false;
            left = true;
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(inair == false){
            rb2d.AddForce((transform.up * jumpspeed), ForceMode2D.Impulse);
            inair = true;
            }else{

            }
        }

        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            if(ready == true)
            {
            if(projectile == projectile3)
            {
                getCount = GameObject.FindGameObjectsWithTag("BombWeapon");
                count = getCount.Length;
                if(count < 3){
                    if(right == true){
                c = Instantiate(projectile, Character.transform.position+(transform.right*0.15f), Character.transform.rotation);
            c.GetComponent<Rigidbody2D>().velocity = transform.right * 5;
            }else if(left == true)
            {
                c = Instantiate(projectile, Character.transform.position+(-transform.right*0.3f), Character.transform.rotation);
                c.GetComponent<Rigidbody2D>().velocity = -transform.right * 5;
            }
            Destroy(c, 5f);
            }else{
                StartCoroutine(waiter());
                }
            }else{
            getCount = GameObject.FindGameObjectsWithTag("Ammo");
            count = getCount.Length;
            if(count < 25){
            if(right == true && inair == false)
            {
            c = Instantiate(projectile, Character.transform.position+(transform.right*0.15f), Character.transform.rotation);
            c.GetComponent<Rigidbody2D>().velocity = transform.right * 5;
            }else if(left == true && inair == false)
            {
                c = Instantiate(projectile, Character.transform.position+(-transform.right*0.15f), Character.transform.rotation);
                c.GetComponent<Rigidbody2D>().velocity = -transform.right * 5;
            }if(right == true && projectile != projectile4)
            {
            c = Instantiate(projectile, Character.transform.position+(transform.right*0.15f), Character.transform.rotation);
            c.GetComponent<Rigidbody2D>().velocity = transform.right * 5;
            }else if(left == true && projectile != projectile4)
            {
                c = Instantiate(projectile, Character.transform.position+(-transform.right*0.15f), Character.transform.rotation);
                c.GetComponent<Rigidbody2D>().velocity = -transform.right * 5;
            }
            Destroy(c, 4f);
            }else
            {
                StartCoroutine(waiter());
            }
            }
            }
        }

        if(Input.GetKey(KeyCode.Mouse0))
        {
            if(ready == true)
            {
            if(projectile == projectile4 || projectile == secretprojectile)
            {
                getCount = GameObject.FindGameObjectsWithTag("ShotgunAmmo");
                count = getCount.Length;
                if(count < 250){
                   if(right == true && inair == false)
            {
            c = Instantiate(projectile, Character.transform.position+(transform.right*0.15f), Character.transform.rotation);
            c.GetComponent<Rigidbody2D>().velocity = transform.right * 5;
            }else if(left == true && inair == false)
            {
                c = Instantiate(projectile, Character.transform.position+(-transform.right*0.15f), Character.transform.rotation);
                c.GetComponent<Rigidbody2D>().velocity = -transform.right * 5;
            }else if(inair == true)
            {
                c = Instantiate(projectile, Character.transform.position+((-transform.up * 0.45f) + (transform.right * 0.3f)), bulletrotation);
            }
            Destroy(c, 5f);
            }else{
                StartCoroutine(waiter());
                }
            }
            }
        }

        if(Input.GetMouseButtonDown(1))
        {
            if(ready == true)
            {
            if(melee == melee1)
            {
                getCount = GameObject.FindGameObjectsWithTag("Melee");
                count = getCount.Length;
                if(count < 1){
                   if(right == true)
            {
            c = Instantiate(melee, Character.transform.position+(transform.right*1.15f), Character.transform.rotation);
            }else if(left == true)
            {
                c = Instantiate(melee, Character.transform.position+(-transform.right*1.15f), Character.transform.rotation);
                Vector3 theScale = c.transform.localScale;
                theScale.x *= -1;
                c.transform.localScale = theScale;
            }
            Destroy(c, 0.5f);
            }else{
                StartCoroutine(waiter());
                }
            }
            }
        }

        if(Input.GetKeyDown(KeyCode.H))
        {
            if(ready == true)
            {
            if(melee == melee1)
            {
                getCount = GameObject.FindGameObjectsWithTag("Melee");
                count = getCount.Length;
                if(count < 1){
                   if(right)
            {
            c = Instantiate(melee, Character.transform.position+(transform.right*1.15f), Character.transform.rotation);
            c.GetComponent<Rigidbody2D>().velocity = transform.right * 5;

            }else if(left)
            {
                c = Instantiate(melee, Character.transform.position+(-transform.right*1.15f), Character.transform.rotation);
                c.GetComponent<Rigidbody2D>().velocity = -transform.right * 5;
                Vector3 theScale = c.transform.localScale;
                theScale.x *= -1;
                c.transform.localScale = theScale;
            }
            Destroy(c, 2.5f);
            }else{
                StartCoroutine(waiter());
                }
            }
            }
        }

        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            if(right == true)
            {
            Character.GetComponent<Rigidbody2D>().velocity = transform.right * 5;
            }else if(left == true)
            {
                Character.GetComponent<Rigidbody2D>().velocity = -transform.right * 5;
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

    void OnTriggerEnter2D(Collider2D collision)
    {
        switch(collision.gameObject.tag){
        case "Default Weapon":
        projectile = projectile1;
        break;
        case "Super Weapon":
        projectile = projectile2;
        break;
        case "Bomb":
        projectile = projectile3;
        break;
        case "Shotgun":
        projectile = projectile4;
        break;
        case "harm":
        HP -= 1;
        h.text = HP.ToString();
        if(HP >= 1){
        }else{
            o.gameObject.SetActive(true);
            h.text = "0";
        }
        break;
        case "???":
        projectile = secretprojectile;
        break;
        case "Default Melee":
        melee = melee1;
        break;
        }
    }

    IEnumerator waiter()
    {

        ready = false;

        yield return new WaitForSeconds(8);

        ready = true;
    }

    void OnBecameInvisible()
    {
        HP -= 99999;
        h.text = "0";
        o.gameObject.SetActive(true);
    }
}
