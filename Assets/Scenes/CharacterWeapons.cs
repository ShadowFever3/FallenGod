using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterWeapons : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    GameObject Character, projectile1, projectile2, projectile3, projectile4, secretprojectile, melee1, melee2;
    GameObject c, projectile, melee;
    [SerializeField]
    Quaternion bulletrotation;

    private GameObject[] getCount, getCount1;

    int count, count1, HP;
    void Start()
    {
        CharacterSettings.ready = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            if(CharacterSettings.ready == true)
            {
            if(projectile == projectile3)
            {
                getCount = GameObject.FindGameObjectsWithTag("BombWeapon");
                count = getCount.Length;
                if(count < 3){
                    if(CharacterSettings.right == true){
                c = Instantiate(projectile, Character.transform.position+(transform.right*0.15f), Character.transform.rotation);
            c.GetComponent<Rigidbody2D>().velocity = transform.right * 5;
            }else if(CharacterSettings.left == true)
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
            if(CharacterSettings.right == true && CharacterSettings.inair == false)
            {
            c = Instantiate(projectile, Character.transform.position+(transform.right*0.15f), Character.transform.rotation);
            c.GetComponent<Rigidbody2D>().velocity = transform.right * 5;
            }else if(CharacterSettings.left == true && CharacterSettings.inair == false)
            {
                c = Instantiate(projectile, Character.transform.position+(-transform.right*0.15f), Character.transform.rotation);
                c.GetComponent<Rigidbody2D>().velocity = -transform.right * 5;
            }if(CharacterSettings.right == true && projectile != projectile4)
            {
            c = Instantiate(projectile, Character.transform.position+(transform.right*0.15f), Character.transform.rotation);
            c.GetComponent<Rigidbody2D>().velocity = transform.right * 5;
            }else if(CharacterSettings.left == true && projectile != projectile4)
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
            if(CharacterSettings.ready == true)
            {
            if(projectile == projectile4 || projectile == secretprojectile)
            {
                getCount = GameObject.FindGameObjectsWithTag("ShotgunAmmo");
                count = getCount.Length;
                if(count < 250){
                   if(CharacterSettings.right == true && CharacterSettings.inair == false)
            {
            c = Instantiate(projectile, Character.transform.position+(transform.right*0.15f), Character.transform.rotation);
            c.GetComponent<Rigidbody2D>().velocity = transform.right * 5;
            }else if(CharacterSettings.left == true && CharacterSettings.inair == false)
            {
                c = Instantiate(projectile, Character.transform.position+(-transform.right*0.15f), Character.transform.rotation);
                c.GetComponent<Rigidbody2D>().velocity = -transform.right * 5;
            }else if(CharacterSettings.inair == true)
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
            if(CharacterSettings.ready == true)
            {
                getCount = GameObject.FindGameObjectsWithTag("Melee");
                count = getCount.Length;
                if(count < 1){
                   if(CharacterSettings.right == true)
            {
            c = Instantiate(melee, Character.transform.position+(transform.right*1.75f), Character.transform.rotation);
            }else if(CharacterSettings.left == true)
            {
                c = Instantiate(melee, Character.transform.position+(-transform.right*1.75f), Character.transform.rotation);
                Vector3 theScale = c.transform.localScale;
                theScale.x *= -1.4f;
                c.transform.localScale = theScale;
            }
            Destroy(c, 0.5f);
            }else{
                StartCoroutine(waiter());
                }
            }
        }

        if(Input.GetKeyDown(KeyCode.H))
        {
            if(CharacterSettings.ready == true)
            {
            if(melee == melee1)
            {
                getCount = GameObject.FindGameObjectsWithTag("Melee");
                count = getCount.Length;
                if(count < 1){
                   if(CharacterSettings.right)
            {
            c = Instantiate(melee, Character.transform.position+(transform.right*1.55f), Character.transform.rotation);
            c.GetComponent<Rigidbody2D>().velocity = transform.right * 5;

            }else if(CharacterSettings.left)
            {
                c = Instantiate(melee, Character.transform.position+(-transform.right*1.55f), Character.transform.rotation);
                c.GetComponent<Rigidbody2D>().velocity = -transform.right * 5;
                Vector3 theScale = c.transform.localScale;
                theScale.x *= -1.4f;
                c.transform.localScale = theScale;
            }
            Destroy(c, 2.5f);
            }else{
                StartCoroutine(waiter());
                }
            }
            }
        }     

        IEnumerator waiter()
    {

        CharacterSettings.ready = false;

        yield return new WaitForSeconds(8);

        CharacterSettings.ready = true;
    }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        switch(collision.gameObject.tag){
        case "Default Weapon":
        WeaponSaving.projectileset = 1;
        break;
        case "Super Weapon":
        WeaponSaving.projectileset = 2;
        break;
        case "Bomb":
        WeaponSaving.projectileset = 3;
        break;
        case "Shotgun":
        WeaponSaving.projectileset = 4;
        break;
        case "Default Melee":
        WeaponSaving.meleeset = 1;
        break;
        case "Sword":
        WeaponSaving.meleeset = 2;
        break;
        }

        switch(WeaponSaving.projectileset){

            case 1:
            projectile = projectile1;
            break;

            case 2:
            projectile = projectile2;
            break;

            case 3:
            projectile = projectile3;
            break;

            case 4:
            projectile = projectile4;
            break;

            case 5:
            projectile = secretprojectile;
            break;
        }

        switch(WeaponSaving.meleeset){

            case 1:
            melee = melee1;
            break;

            case 2:
            melee = melee2;
            break;
        }
    }

}
